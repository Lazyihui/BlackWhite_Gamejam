using System;
using UnityEngine;
using UnityEngine.UI;

namespace BW {
    public class Panel_StartGame : MonoBehaviour {
        [SerializeField] Button btn_StartGame;
        public Action OnStartGameHandler;

        [SerializeField] Button btn_SelectStage;

        public Action SelectStageHandler;


        public void Ctor() {
            btn_StartGame.onClick.AddListener(() => {
                if (OnStartGameHandler != null) {
                    OnStartGameHandler();
                }
            });

            btn_SelectStage.onClick.AddListener(() => {
                if (SelectStageHandler != null) {
                    SelectStageHandler();
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