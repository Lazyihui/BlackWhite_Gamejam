using System;
using UnityEngine;


namespace BW {

    public static class Game_Business {

        public static void Enter(GameContext ctx) {
            var game = ctx.gameEntity;
            game.state = GameState.Game;

            // stage
            int stageID = game.stageCurID;
            bool has = ctx.templateCore.TryGetStage(stageID, out StageTM tm);
            if (!has) {
                Debug.LogError("stage not found: " + stageID);
                return;
            }

            // map
            MapDomain.Spawn(ctx, game.stageCurID);

            for (int i = 0; i < tm.roleSpawns.Length; i += 1) {
                RoleSpawnTM spawnTM = tm.roleSpawns[i];
                // TODO:这个TypeID好像可以不用了 就是不要了 等等改
                RoleEntity role = RoleDomain.SpawnBySpawn(ctx, 1, spawnTM);
            }

            for (int i = 0; i < tm.flagSpawns.Length; i += 1) {
                FlagSpawnTM spawnTM = tm.flagSpawns[i];
                // TODO:这个TypeID好像可以不用了 就是不要了 等等改
                FlagDomain.SpawnBySpawner(ctx, 1, spawnTM);
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
            GameUserInterface.GameReStart(ctx);

        }

        public static void LogicTick(GameContext ctx, float dt) {
            var input = ctx.inputCore;

            RoleEntity role = ctx.Get_Role();
            // TODO:可以加一个RoleDomain.Tick(ctx,role)来处理role的逻辑
            // TODO: 问： 是传入Vector2还是传入Ctx (目前传ctx)
            RoleDomain.Move(role, input.moveAxis);
            RoleDomain.Jump(ctx, role);
            RoleDomain.GroundCheck(ctx, role);
            RoleDomain.X_InGround(ctx, role);

            RoleDomain.TouchFlag(ctx, role);
            RoleDomain.Shuttleboundary(ctx, role);
            RoleDomain.SetLastDir(ctx, role);
        }

        public static void LastTick(GameContext ctx, float dt) {


        }

    }
}