using BW;
using System;
using UnityEngine;

public class UIApp {
    UIContext ctx;

    public UIEvent events => ctx.uiEvent;

    public UIApp() {
        ctx = new UIContext();
    }

    public UIEvent GetEvents() {
        return ctx.uiEvent;
    }

    public void SetEvents(UIEvent value) {
        ctx.uiEvent = value;
    }

    public void Inject(AssetsCore assetsCore, Canvas canvas) {
        ctx.Inject(assetsCore, canvas);
    }


    #region    Panel_NextStage

    public void Panel_NextStage_Open() {
        Panel_NextStage panel = ctx.panel_NextStage;

        if (panel == null) {
            GameObject go = ctx.assetsCore.Panel_GetNextStage();
            if (!go) {
                Debug.LogError("Panel_NextStage not found");
                return;
            }

            panel = GameObject.Instantiate(go, ctx.canvas.transform).GetComponent<Panel_NextStage>();
            panel.Ctor();
            panel.OnEnterNextStageGameHandler = () => {
                ctx.uiEvent.Panel_NextStage_EnterNextStageClick();
            };
            panel.OnReStartGameHandler = () => {
                ctx.uiEvent.Panel_NextStage_ReStartGameClick();
            };
        }

        ctx.panel_NextStage = panel;
    }

    public void Panel_NextStage_Close() {
        Panel_NextStage panel = ctx.panel_NextStage;
        if (panel == null) {
            return;
        }
        panel.TearDown();
    }

    #endregion

    #region    Panel_StartGame  
    public void Panel_StartGame_Open() {
        Panel_StartGame panel = ctx.panel_StartGame;

        if (panel == null) {
            GameObject go = ctx.assetsCore.Panel_GetStartGame();
            if (!go) {
                Debug.LogError("Panel_StartGame not found");
                return;
            }

            panel = GameObject.Instantiate(go, ctx.canvas.transform).GetComponent<Panel_StartGame>();
            panel.Ctor();
            panel.OnStartGameHandler = () => {
                ctx.uiEvent.Panel_StartGame_StartGameClick();
            };
            panel.SelectStageHandler = () => {
                ctx.uiEvent.Panel_StartGame_SelectStageClick();
            };
        }

        ctx.panel_StartGame = panel;
    }

    public void Panel_StartGame_Close() {
        Panel_StartGame panel = ctx.panel_StartGame;
        if (panel == null) {
            return;
        }
        panel.TearDown();
    }


    #endregion

    #region  Panel_GameOver

    public void Panel_GameOver_Open() {
        Panel_GameOver panel = ctx.panel_GameOver;

        if (panel == null) {
            GameObject go = ctx.assetsCore.Panel_GetGameOver();
            if (!go) {
                Debug.LogError("Panel_GameOver not found");
                return;
            }

            panel = GameObject.Instantiate(go, ctx.canvas.transform).GetComponent<Panel_GameOver>();
            panel.Ctor();
            panel.OnAgainGameHandler = () => {
                ctx.uiEvent.Panel_GameOver_AgainGameClick();
            };
            panel.OnQuitGameHandler = () => {
                ctx.uiEvent.Panel_GameOver_QuitGameClick();
            };
        }

        ctx.panel_GameOver = panel;
    }

    public void Panel_GameOver_Close() {
        Panel_GameOver panel = ctx.panel_GameOver;
        if (panel == null) {
            return;
        }
        panel.TearDown();
    }

    #endregion


    #region  Panel_GamePause

    public void Panel_GamePause_Open() {
        Panel_GamePause panel = ctx.panel_GamePause;

        if (panel == null) {
            GameObject go = ctx.assetsCore.Panel_GetGamePause();
            if (!go) {
                Debug.LogError("Panel_GamePause not found");
                return;
            }

            panel = GameObject.Instantiate(go, ctx.canvas.transform).GetComponent<Panel_GamePause>();
            panel.Ctor();
            panel.OnContinueGameHandler = () => {
                ctx.uiEvent.Panel_GamePause_ContinueGameClick();
            };
            panel.OnQuitGameHandler = () => {
                ctx.uiEvent.Panel_GamePause_QuitGameClick();
            };
        }

        ctx.panel_GamePause = panel;
    }

    public void Panel_GamePause_Close() {
        Panel_GamePause panel = ctx.panel_GamePause;
        if (panel == null) {
            return;
        }
        panel.TearDown();
    }

    #endregion

    #region  Panel_SelectStage
    public void Panel_SelectStage_Open() {
        Panel_SelectStage panel = ctx.panel_SelectStage;

        if (panel == null) {
            GameObject go = ctx.assetsCore.Panel_GetSelectStage();
            if (!go) {
                Debug.LogError("Panel_SelectStage not found");
                return;
            }

            panel = GameObject.Instantiate(go, ctx.canvas.transform).GetComponent<Panel_SelectStage>();
            panel.Ctor();
            panel.On1GameHandler = (int stage) => {
                ctx.uiEvent.Panel_SelectStage1_SelectStageClick(stage);
            };

            panel.On2GameHandler = (int stage) => {
                ctx.uiEvent.Panel_SelectStage2_SelectStageClick(stage);
            };

            panel.On3GameHandler = (int stage) => {
                ctx.uiEvent.Panel_SelectStage3_SelectStageClick(stage);
            };

            panel.On4GameHandler = (int stage) => {
                ctx.uiEvent.Panel_SelectStage4_SelectStageClick(stage);
            };

            panel.On5GameHandler = (int stage) => {
                ctx.uiEvent.Panel_SelectStage5_SelectStageClick(stage);
            };

        }

        ctx.panel_SelectStage = panel;
    }

    public void Panel_SelectStage_Close() {
        Panel_SelectStage panel = ctx.panel_SelectStage;
        if (panel == null) {
            return;
        }
        panel.TearDown();
    }


    #endregion
}