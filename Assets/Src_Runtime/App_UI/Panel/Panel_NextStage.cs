using System;
using UnityEngine;
using UnityEngine.UI;

namespace BW {
    public class Panel_NextStage : MonoBehaviour {
        [SerializeField] Button btn_ReStartGame;
        public Action OnReStartGameHandler;

        [SerializeField] Button btn_EnterNextStage;
        public Action OnEnterNextStageGameHandler;
        public void Ctor() {
            btn_ReStartGame.onClick.AddListener(() => {
                if (OnReStartGameHandler != null) {
                    OnReStartGameHandler();
                }
            });

            btn_EnterNextStage.onClick.AddListener(() => {
                if (OnEnterNextStageGameHandler != null) {
                    OnEnterNextStageGameHandler();
                }
            });
        }


        public void Show() {
            gameObject.SetActive(true);
        }

        public void TearDown() {

            Destroy(gameObject);
        }


    }
}