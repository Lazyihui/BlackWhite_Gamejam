using BW;
using System;
using UnityEngine;

public static class Login_Business {
    public static void Enter(GameContext ctx) {
        ctx.uiApp.Panel_Login_Open();
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


    }

    public static void LogicTick(GameContext ctx, float dt) {

    }

    public static void LastTick(GameContext ctx, float dt) { }

}