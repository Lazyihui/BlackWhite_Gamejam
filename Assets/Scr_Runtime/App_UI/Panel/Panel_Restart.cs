using BW;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Panel_Restart : MonoBehaviour
{
    [SerializeField] Button btnRestart;

    public Action OnClickRestartHandle;

    public void Ctor()
    {
        btnRestart.onClick.AddListener(() => {
            if(OnClickRestartHandle != null)
            {
                OnClickRestartHandle.Invoke();
            }
        });
    }

    public void TearDown()
    {
        Destroy(gameObject);
    }
}
