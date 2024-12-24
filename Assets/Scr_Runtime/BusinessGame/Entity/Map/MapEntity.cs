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
            mapBlack.SetActive(!mapBlack.activeSelf);
            mapWhite.SetActive(!mapWhite.activeSelf);
        }

    }
}