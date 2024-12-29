using System;
using UnityEngine;
using UnityEditor;

namespace BW {

    public class StageEM : MonoBehaviour {
        public int stageID;
        public StageSO so;

        [SerializeField] GameObject mapEntity;

        // 第一件事将数据保存到TM中

        [ContextMenu("Save")]
        public void Save() {
            string n = "stage_" + stageID;
            if (gameObject.name != n) {
                gameObject.name = n;
            }

            so.tm.stageID = stageID;

            Debug.Log("Save");

            // 这里是每个TM的数据保存

        }

        public void SaveRole() {
            
        }
    }
}
