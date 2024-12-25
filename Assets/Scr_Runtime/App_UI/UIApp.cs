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

    #region    Panel_Login
    public void Panel_Login_Open() {
        Panel_Login panel = ctx.panel_Login;

        if (panel == null) {
            GameObject go = ctx.assetsCore.Panel_GetLogin();
            if (!go) {
                Debug.LogError("Panel_Login not found");
                return;
            }

            panel = GameObject.Instantiate(go, ctx.canvas.transform).GetComponent<Panel_Login>();
            panel.Ctor();
            panel.OnStartGameHandler = () => {
                ctx.uiEvent.Panel_Login_StartGameClick();
            };
        }

        ctx.panel_Login = panel;
    }

    public void Panel_Login_Close() {
        Panel_Login panel = ctx.panel_Login;
        if (panel == null) {
            return;
        }
        panel.TearDown();
    }

    #endregion
}