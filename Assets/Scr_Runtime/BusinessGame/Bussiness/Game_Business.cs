using System;
using UnityEngine;


namespace BW {

    public static class Game_Business {

        public static void Enter(GameContext ctx) {
            RoleEntity role = RoleDomain.Spawn(ctx, 1);
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

        public static void PreTick(GameContext ctx, float dt) { }

        public static void LogicTick(GameContext ctx, float dt) {
            var input = ctx.inputCore;

            RoleEntity role = ctx.Get_Role();
            // TODO: 是传入Vector2还是传入Ctx
            RoleDomain.Move(role, input.moveAxis);
            RoleDomain.Jump(ctx, role);
            RoleDomain.GroundCheck(ctx, role);
        }

        public static void LastTick(GameContext ctx, float dt) { }

    }
}