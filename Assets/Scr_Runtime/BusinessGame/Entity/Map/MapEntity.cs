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

        public void SetWhiteActive(bool active) {
            mapWhite.SetActive(active);
        }

        public void SetBlackActive(bool active) {
            mapBlack.SetActive(active);
        }
        
    }
}