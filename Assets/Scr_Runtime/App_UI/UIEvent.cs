using BW;
using System;
using UnityEngine;

public class UIEvent
{
    public Action panel_Restart_RestartHandle;

    public void Panel_Restart_RestartClick()
    {
        if (panel_Restart_RestartHandle != null)
        {
            panel_Restart_RestartHandle.Invoke();
        }
    }
}