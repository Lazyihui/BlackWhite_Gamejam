using System;
using UnityEngine;


namespace BW {

    public static class Game_Business {

        public static void Enter(GameContext ctx) {

            // map
            MapDomain.Spawn(ctx, 1);

            // role
            RoleEntity role = RoleDomain.Spawn(ctx, 1);
            Vector2 pos = new Vector2(8, -4);
            FlagDomain.Spawn(ctx, 1, pos);
        }

        public static void Tick(GameContext ctx, float dt) {
            PreTick(ctx, dt);

            ref float restFixTime = ref ctx.gameEntity.restFixTime;

            restFixTime += dt;

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

        public static void LastTick(GameContext ctx, float dt) { }

    }
}