using BW;
using System;
using UnityEngine;

public class UIContext {
    public UIEvent uiEvent;

    //panel
    public Panel_Restart panel_Restart;
    public Panel_NextStage panel_NextStage;
    public Panel_StartGame panel_StartGame;


    //core
    public AssetsCore assetsCore;
    public Canvas canvas;

    public UIContext() {
        uiEvent = new UIEvent();
    }

    public void Inject(AssetsCore assetsCore, Canvas canvas) {
        this.assetsCore = assetsCore;
        this.canvas = canvas;
    }
}