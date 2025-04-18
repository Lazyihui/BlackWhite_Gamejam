using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BW {

    public class Main : MonoBehaviour {

        [SerializeField] int maxStageID;

        [SerializeField] int curStageID;

        GameContext ctx;

        bool isTearDown = false;
        bool isInit = false;
        void Awake() {

            // Init
            ctx = new GameContext();

            Canvas canvas = GameObject.Find("Canvas").GetComponent<Canvas>();
            ctx.InJect(canvas);
            ctx.gameEntity.maxStageID = maxStageID;
            ctx.gameEntity.stageCurID = curStageID;

            // Binding
            Binding();

            Action action = async () => {

                await ctx.assetsCore.LoadAll();
                await ctx.templateCore.LoadAll();

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

                GameUserInterface.ClearAllPreviousStageData(ctx);
                ctx.gameEntity.stageCurID++;
                Game_Business.Enter(ctx);
            };

            events.OnNextStage_ReStartGameHandle += () => {
                ctx.uiApp.Panel_NextStage_Close();

                GameUserInterface.ClearAllPreviousStageData(ctx);
                Game_Business.Enter(ctx);

            };

            // panel_StartGame

            events.On_StartGame_StartGameHandler += () => {
                ctx.uiApp.Panel_StartGame_Close();

                GameUserInterface.ClearAllPreviousStageData(ctx);
                Game_Business.Enter(ctx);
            };

            events.OnStartGame_SelectStageHandle += () => {
                ctx.uiApp.Panel_StartGame_Close();

                ctx.uiApp.Panel_SelectStage_Open();
            };

            // Panel_GameOver

            events.OnGameOver_AgainGameHandler += () => {

                ctx.uiApp.Panel_GameOver_Close();
                GameUserInterface.ClearAllGameData(ctx);
                Login_Business.Enter(ctx);

            };

            events.OnGameOver_QuitGameHandler += () => {
                // 退出程序
                Application.Quit();
            };

            // panel_GamePause

            events.OnGamePause_ContinueGameHandler += () => {
                ctx.uiApp.Panel_GamePause_Close();
                Debug.Log("ContinueGame");
            };

            events.OnGamePause_QuitGameHandler += () => {
                Application.Quit();
                Debug.Log("QuitGame");
            };

            // panel_selectStage

            events.OnSelectStage1_SelectStageHandle += (int stageID) => {
                ctx.uiApp.Panel_SelectStage_Close();
                Debug.Log(ctx.gameEntity.stageCurID);

                game.stageCurID = stageID;
                GameUserInterface.ClearAllGameData(ctx);
                Game_Business.Enter(ctx);
            };


            events.OnSelectStage2_SelectStageHandle += (int stageID) => {
                ctx.uiApp.Panel_SelectStage_Close();

                GameUserInterface.ClearAllGameData(ctx);

                game.stageCurID = stageID;
                Game_Business.Enter(ctx);
            };

            events.OnSelectStage3_SelectStageHandle += (int stageID) => {
                ctx.uiApp.Panel_SelectStage_Close();

                GameUserInterface.ClearAllGameData(ctx);

                game.stageCurID = stageID;
                Game_Business.Enter(ctx);
            };

            events.OnSelectStage4_SelectStageHandle += (int stageID) => {
                ctx.uiApp.Panel_SelectStage_Close();

                GameUserInterface.ClearAllGameData(ctx);

                game.stageCurID = stageID;
                Game_Business.Enter(ctx);
            };

            events.OnSelectStage5_SelectStageHandle += (int stageID) => {
                ctx.uiApp.Panel_SelectStage_Close();

                GameUserInterface.ClearAllGameData(ctx);

                game.stageCurID = stageID;
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
            ctx.templateCore.UnLoadAll();

        }

    }
}
