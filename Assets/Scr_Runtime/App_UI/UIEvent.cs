using BW;
using System;
using UnityEngine;

public class UIEvent {
    public Action OnRestart_RestartHandle;

    public void Panel_Restart_RestartClick() {
        if (OnRestart_RestartHandle != null) {
            Debug.Log("Panel_Restart_RestartClick");
            OnRestart_RestartHandle.Invoke();
        }
    }

    #region Panel_Login
    public Action OnLogin_StartGameHandle;

    public void Panel_Login_StartGameClick() {
        if (OnLogin_StartGameHandle != null) {
            OnLogin_StartGameHandle.Invoke();
        }
    }

    #endregion
    
    #region  Panel_NextStage
    public Action OnNextStage_EnterNextStageHandle;
    public void Panel_NextStage_EnterNextStageClick() {
        if (OnNextStage_EnterNextStageHandle != null) {
            OnNextStage_EnterNextStageHandle.Invoke();
        }
    }

    public Action OnNextStage_ReStartGameHandle;

    public void Panel_NextStage_ReStartGameClick() {
        if (OnNextStage_ReStartGameHandle != null) {
            OnNextStage_ReStartGameHandle.Invoke();
        }
    }
    #endregion
}