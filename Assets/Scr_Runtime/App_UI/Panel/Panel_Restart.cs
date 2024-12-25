using System;
using UnityEngine;
using UnityEngine.UI;


namespace BW {

    public class Panel_Restart : MonoBehaviour {
        [SerializeField] Button btnRestart;

        public Action OnClickRestartHandle;

        public void Ctor() {
            btnRestart.onClick.AddListener(() => {
                if (OnClickRestartHandle != null) {
                    OnClickRestartHandle.Invoke();
                }
            });
        }

        public void TearDown() {
            Destroy(gameObject);
        }
    }
}
