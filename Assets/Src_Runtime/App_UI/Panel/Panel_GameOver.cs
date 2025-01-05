using System;
using UnityEngine;
using UnityEngine.UI;

namespace BW {
    public class Panel_GameOver : MonoBehaviour {
        [SerializeField] Button btn_AgainGame;
        public Action OnAgainGameHandler;

        [SerializeField] Button btn_QuitGame;
        public Action OnQuitGameHandler;
        public void Ctor() {
            btn_AgainGame.onClick.AddListener(() => {
                if (OnAgainGameHandler != null) {
                    OnAgainGameHandler();
                }
            });

            btn_QuitGame.onClick.AddListener(() => {
                if (OnQuitGameHandler != null) {
                    OnQuitGameHandler();
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