using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BW {

    public class Main : MonoBehaviour {

        GameContext ctx;

        bool isTearDown = false;
        bool isInit = false;
        void Awake() {
            Debug.Log("Main Awake");

            // Init
            ctx = new GameContext();
            // Canvas screenCanvas = GameObject.Find("ScreenCanvas").GetComponent<Canvas>();
            // Canvas worldCanvas = GameObject.Find("WorldCanvas").GetComponent<Canvas>();

            Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
            ctx.InJect(canvas);

            // Binding
            Binding();

            Action action = async () => {

                await ctx.assetsCore.LoadAll();

                isInit = true;

                // GameEnter;
                Login_Business.Enter(ctx);
            };

            action.Invoke();

        }

        void Binding() {
            var events = ctx.uiApp.GetEvents();
            var game = ctx.gameEntity;

            // panel_Restart
            events.OnRestart_RestartHandle += () => {
                GameUserInterface.Restart(ctx);
            };


            // panel_NextStage
            events.OnNextStage_EnterNextStageHandle += () => {
                ctx.uiApp.Panel_NextStage_Close();

                GameUserInterface.ClearAllGameDate(ctx);
                ctx.gameEntity.stageCurID++;
                Game_Business.Enter(ctx);
            };

            events.OnNextStage_ReStartGameHandle += () => {
                ctx.uiApp.Panel_NextStage_Close();

                GameUserInterface.ClearAllGameDate(ctx);
                Game_Business.Enter(ctx);

            };

            // panel_StartGame

            events.On_StartGame_StartGameHandler += () => {
                ctx.uiApp.Panel_StartGame_Close();

                GameUserInterface.ClearAllGameDate(ctx);
                Game_Business.Enter(ctx);
            };
        }

        void Update() {

            if (!isInit) {
                return;
            }

            float dt = Time.deltaTime;

            // Input
            ctx.inputCore.Process();

            // Tick
            var game = ctx.gameEntity;

            if (game.state == GameState.LoginEnter) {
                Login_Business.Tick(ctx, dt);
            } else if (game.state == GameState.Game) {
                Game_Business.Tick(ctx, dt);
            }
        }


        void OnDestroy() {
            TearDown();
        }

        void ApplciationQuit() {
            TearDown();
        }

        void TearDown() {
            if (isTearDown) {
                return;
            }
            isTearDown = true;
            ctx.assetsCore.UnLoadAll();

        }

    }
}
