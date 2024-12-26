using System;
using UnityEngine;


namespace BW {

    public static class Game_Business {

        public static void Enter(GameContext ctx) {
            var game = ctx.gameEntity;
            game.state = GameState.Game;

            // ui
            ctx.uiApp.Panel_Restart_Open();

            // map
            MapDomain.Spawn(ctx, game.stageCurID);

            // role
            RoleEntity role = RoleDomain.Spawn(ctx, 1);
            Vector2 pos = new Vector2(7.75f, -3.9f);
            FlagDomain.Spawn(ctx, 1, pos);

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
            // TODO:可以加一个RoleDomain.Tick(ctx,role)来处理role的逻辑
            // TODO: 问： 是传入Vector2还是传入Ctx 
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