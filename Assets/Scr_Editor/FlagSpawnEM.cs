using System;
using UnityEngine;
using UnityEditor;

namespace BW {
    [ExecuteInEditMode]
    public class FlagSpawnEM : MonoBehaviour {
        public FlagSpawnTM spawnTM;
        void Update() {


            var so = spawnTM.so;
            if (so == null) {
                return;
            }

            var tm = so.tm;
            string n = "Flag_Entity_" + tm.typeName;
            if (gameObject.name != n) {
                gameObject.name = n;
            }


        }

        [ContextMenu("Save")]
        public void Save() {
            Debug.Log("Save_FlagSpawn");
            spawnTM.position = transform.position;
            spawnTM.rotation = transform.rotation.eulerAngles;
        }

    }
}