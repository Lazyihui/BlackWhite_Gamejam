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

            events.OnRestart_RestartHandle += () => {
                GameUserInterface.Restart(ctx);
            };

            events.OnLogin_StartGameHandle += () => {
                ctx.uiApp.Panel_Login_Close();
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

            if (game.state == GameState.Login) {
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
