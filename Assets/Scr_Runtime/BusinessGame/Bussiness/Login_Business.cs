using BW;
using System;
using UnityEngine;

public static class Login_Business {
    public static void Enter(GameContext ctx) {
        var game = ctx.gameEntity;
        game.state = GameState.LoginEnter;

        // ui
        ctx.uiApp.Panel_StartGame_Open();

        // map
        MapDomain.Spawn(ctx, 0);

        // role
        RoleEntity role = RoleDomain.Spawn(ctx, 1);

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

    public static void LogicTick(GameContext ctx, float dt) {
        var input = ctx.inputCore;

        RoleEntity role = ctx.Get_Role();
        RoleDomain.Move(role, input.moveAxis);
        RoleDomain.Jump(ctx, role);

        RoleDomain.GroundCheck(ctx, role);
        RoleDomain.X_InGround(ctx, role);

        RoleDomain.Shuttleboundary(ctx, role);
        RoleDomain.SetLastDir(ctx, role);
    }

    public static void LastTick(GameContext ctx, float dt) { }

}