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
    public Action OnLogin_EnterGameHandle;

    public void Panel_Login_StartGameClick() {
        if (OnLogin_EnterGameHandle != null) {
            OnLogin_EnterGameHandle.Invoke();
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


    #region Panel_StartGame
    public Action On_StartGame_StartGameHandler;

    public void Panel_StartGame_StartGameClick() {
        if (On_StartGame_StartGameHandler != null) {
            On_StartGame_StartGameHandler.Invoke();
        }
    }

    #endregion

    #region Panel_GameOver

    public Action OnGameOver_AgainGameHandler;

    public void Panel_GameOver_AgainGameClick() {
        if (OnGameOver_AgainGameHandler != null) {
            OnGameOver_AgainGameHandler.Invoke();
        }
    }

    public Action OnGameOver_QuitGameHandler;

    public void Panel_GameOver_QuitGameClick() {
        if (OnGameOver_QuitGameHandler != null) {
            OnGameOver_QuitGameHandler.Invoke();
        }
    }


    #endregion
}