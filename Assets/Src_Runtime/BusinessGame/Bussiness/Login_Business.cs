using BW;
using System;
using UnityEngine;

public static class Login_Business {
    public static void Enter(GameContext ctx) {
        var game = ctx.gameEntity;
        game.state = GameState.LoginEnter;

        // ui
        ctx.uiApp.Panel_StartGame_Open();

        MapDomain.Spawn(ctx, 0);

        bool has = ctx.templateCore.TryGetStage(0, out StageTM tm);


        for (int i = 0; i < tm.roleSpawns.Length; i += 1) {
            RoleSpawnTM spawnTM = tm.roleSpawns[i];
            RoleEntity role = RoleDomain.SpawnBySpawn(ctx, 1, spawnTM);
        }

        ctx.audioBG = AudioDoamin.Spawn(ctx, 0);
        AudioDoamin.PlayAudio(ctx, ctx.audioBG);

        ctx.audioJump = AudioDoamin.Spawn(ctx, 1);

    }

    public static void Tick(GameContext ctx, float dt) {
        PreTick(ctx, dt);

        ref float restFixTime = ref ctx.gameEntity.restFixTime;

        restFixTime += dt;
        const float FIX_INTERVAL = 0.020f;

        if (restFixTime <= FIX_INTERVAL) {

            LogicTick(ctx, restFixTime);

            restFixTime = 0;
        } else {
            while (restFixTime >= FIX_INTERVAL) {
                LogicTick(ctx, FIX_INTERVAL);
                restFixTime -= FIX_INTERVAL;
            }
        }

        LastTick(ctx, dt);
    }

    public static void PreTick(GameContext ctx, float dt) {

        // map
        MapEntity map = ctx.Get_Map();
        // role
        RoleEntity role = ctx.Get_Role();

        GameUserInterface.ChangeMapRole(ctx, map, role);
        GameUserInterface.GamePause(ctx);

    }
    static FlagEntity flag;

    public static void LogicTick(GameContext ctx, float dt) {
        var input = ctx.inputCore;

        RoleEntity role = ctx.Get_Role();
        RoleDomain.Move(role, input.moveAxis);
        RoleDomain.Jump(ctx, role);

        RoleDomain.GroundCheck(ctx, role);
        RoleDomain.X_InGround(ctx, role);

        RoleDomain.Shuttleboundary(ctx, role);
        RoleDomain.SetLastDir(ctx, role);

        if (Input.GetKeyDown(KeyCode.L)) {
            Debug.Log("L");
            flag = FlagDomain.Spawn(ctx, 1, new Vector2(-7.5f, -3.9f));

        }

        if (Input.GetKeyDown(KeyCode.P)) {
            FlagDomain.UnSpawn(ctx, flag);
        }
    }

    public static void LastTick(GameContext ctx, float dt) { }

}