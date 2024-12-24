using System;
using UnityEngine;


namespace BW {
    public class MapEntity : MonoBehaviour {

        [SerializeField] GameObject mapWhite;
        [SerializeField] GameObject mapBlack;

        // 关卡ID
        public int stageID;
        public void Ctor() {
        }

        public void Toggle() {
            if (mapWhite.activeSelf) {
                SetWhiteActive(false);
                SetBlackActive(true);
            } else {
                SetWhiteActive(true);
                SetBlackActive(false);
            }
        }

        void SetWhiteActive(bool active) {
            mapWhite.SetActive(active);
        }

        void SetBlackActive(bool active) {
            mapBlack.SetActive(active);
        }

    }
}