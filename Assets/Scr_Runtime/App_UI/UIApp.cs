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

    #region     Panel_Login
    public void Panel_Restart_Open() {
        Panel_Restart panel = ctx.panel_Restart;

        if (panel == null) {
            GameObject go = ctx.assetsCore.Panel_GetRestart();
            if (!go) {
                Debug.LogError("Panel_Restart not found");
                return;
            }

            panel = GameObject.Instantiate(go, ctx.canvas.transform).GetComponent<Panel_Restart>();
            panel.Ctor();
            panel.OnClickRestartHandle = () => {
                ctx.uiEvent.Panel_Restart_RestartClick();
            };
        }

        ctx.panel_Restart = panel;
    }

    public void Panel_Restart_Close() {
        Panel_Restart panel = ctx.panel_Restart;
        if (panel == null) {
            return;
        }
        panel.TearDown();

    }
    #endregion

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

}