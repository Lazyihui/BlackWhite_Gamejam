using BW;
using System;
using UnityEngine;

public class UIApp
{
    UIContext ctx;

    public UIEvent events => ctx.uiEvent;

    public UIApp()
    {
        ctx = new UIContext();
    }

    public UIEvent GetEvents()
    {
        return ctx.uiEvent;
    }

    public void SetEvents(UIEvent value)
    {
        ctx.uiEvent = value;
    }

    public void Inject(AssetsCore assetsCore, Canvas canvas)
    {
        ctx.Inject(assetsCore, canvas);
    }

    public void Panel_Restart_Open()
    {
        Panel_Restart panel = ctx.panel_Restart;

        if(panel == null)
        {
            // Debug.Assert(ctx != null, "UIContext is null");
            // Debug.Assert(ctx.canvas != null, "Canvas is null");
            // GameObject go = ctx.assetsCore.Panel_GetRestart();

            // panel = GameObject.Instantiate(go).GetComponent<Panel_Restart>();
            // panel.Ctor();

            // panel.OnClickRestartHandle += () => {
            //     ctx.uiEvent.Panel_Restart_RestartClick();
            // };

            GameObject restart = ctx.assetsCore.Panel_GetRestart();

            if(!restart)
            {
                Debug.LogError("Panel_Restart not found");
                return;
            }

            panel = GameObject.Instantiate(restart, ctx.canvas.transform).GetComponent<Panel_Restart>();
            panel.Ctor();
            panel.OnClickRestartHandle = () => {
                ctx.uiEvent.Panel_Restart_RestartClick();
            };
        }

        ctx.panel_Restart = panel;
    }

    public void Panel_Restart_Close()
    {
        Panel_Restart panel = ctx.panel_Restart;

        if(panel == null)
        {
            return;
        }
        panel.TearDown();
    }
}