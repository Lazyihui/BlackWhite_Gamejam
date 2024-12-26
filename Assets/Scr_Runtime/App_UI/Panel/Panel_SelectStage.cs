using System;
using UnityEngine;
using UnityEngine.UI;

namespace BW {
    public class Panel_SelectStage : MonoBehaviour {
        [SerializeField] Button btn_1;
        public Action<int> On1GameHandler;

        [SerializeField] Button btn_2;
        public Action<int> On2GameHandler;

        [SerializeField] Button btn_3;
        public Action<int> On3GameHandler;

        [SerializeField] Button btn_4;
        public Action<int> On4GameHandler;

        [SerializeField] Button btn_5;
        public Action<int> On5GameHandler;




        public void Ctor() {
            btn_1.onClick.AddListener(() => {
                if (On1GameHandler != null) {
                    On1GameHandler(1);
                }
            });

            btn_2.onClick.AddListener(() => {
                if (On2GameHandler != null) {
                    On2GameHandler(2);
                }
            });

            btn_3.onClick.AddListener(() => {
                if (On3GameHandler != null) {
                    On3GameHandler(3);
                }
            });

            btn_4.onClick.AddListener(() => {
                if (On4GameHandler != null) {
                    On4GameHandler(4);
                }
            });

            btn_5.onClick.AddListener(() => {
                if (On5GameHandler != null) {
                    On5GameHandler(5);
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