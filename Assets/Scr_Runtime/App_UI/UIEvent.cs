using BW;
using System;
using UnityEngine;

public class UIEvent {
    public Action OnRestart_RestartHandle;

    public void Panel_Restart_RestartClick() {
        if (OnRestart_RestartHandle != null) {
            OnRestart_RestartHandle.Invoke();
        }
    }

    public Action OnLogin_StartGameHandle;

    public void Panel_Login_StartGameClick() {
        if (OnLogin_StartGameHandle != null) {
            OnLogin_StartGameHandle.Invoke();
        }
    }
}