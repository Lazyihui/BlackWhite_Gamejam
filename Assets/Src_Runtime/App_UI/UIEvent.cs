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

    public Action OnStartGame_SelectStageHandle;

    public void Panel_StartGame_SelectStageClick() {
        if (OnStartGame_SelectStageHandle != null) {
            OnStartGame_SelectStageHandle.Invoke();
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

    #region Panel_GamePause

    public Action OnGamePause_ContinueGameHandler;

    public void Panel_GamePause_ContinueGameClick() {
        if (OnGamePause_ContinueGameHandler != null) {
            OnGamePause_ContinueGameHandler.Invoke();
        }
    }

    public Action OnGamePause_QuitGameHandler;

    public void Panel_GamePause_QuitGameClick() {
        if (OnGamePause_QuitGameHandler != null) {
            OnGamePause_QuitGameHandler.Invoke();
        }
    }


    #endregion

    #region Panel_SelectStage
    public Action<int> OnSelectStage1_SelectStageHandle;

    public void Panel_SelectStage1_SelectStageClick(int stage) {
        if (OnSelectStage1_SelectStageHandle != null) {
            OnSelectStage1_SelectStageHandle.Invoke(stage);
        }
    }

    public Action<int> OnSelectStage2_SelectStageHandle;

    public void Panel_SelectStage2_SelectStageClick(int stage) {
        if (OnSelectStage2_SelectStageHandle != null) {
            OnSelectStage2_SelectStageHandle.Invoke(stage);
        }
    }

    public Action<int> OnSelectStage3_SelectStageHandle;

    public void Panel_SelectStage3_SelectStageClick(int stage) {
        if (OnSelectStage3_SelectStageHandle != null) {
            OnSelectStage3_SelectStageHandle.Invoke(stage);
        }
    }

    public Action<int> OnSelectStage4_SelectStageHandle;

    public void Panel_SelectStage4_SelectStageClick(int stage) {
        if (OnSelectStage4_SelectStageHandle != null) {
            OnSelectStage4_SelectStageHandle.Invoke(stage);
        }
    }

    public Action<int> OnSelectStage5_SelectStageHandle;

    public void Panel_SelectStage5_SelectStageClick(int stage) {
        if (OnSelectStage5_SelectStageHandle != null) {
            OnSelectStage5_SelectStageHandle.Invoke(stage);
        }
    }

    #endregion
}