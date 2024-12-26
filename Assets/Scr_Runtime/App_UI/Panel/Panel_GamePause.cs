using BW;
using System;
using UnityEngine;
using UnityEngine.UI;

public class Panel_GamePause : MonoBehaviour
{
    [SerializeField] Button btn_ContinueGame;
    public Action OnContinueGameHandler;

    [SerializeField] Button btn_QuitGame;
    public Action OnQuitGameHandler;

    public void Ctor()
    {
        btn_ContinueGame.onClick.AddListener(() =>
        {
            if (OnContinueGameHandler != null)
            {
                OnContinueGameHandler();
            }
        });

        btn_QuitGame.onClick.AddListener(() =>
        {
            if (OnQuitGameHandler != null)
            {
                OnQuitGameHandler();
            }
        });
    }

    public void Show()
    {
        gameObject.SetActive(true);
    }

    public void TearDown()
    {

        Destroy(gameObject);
    }
}
