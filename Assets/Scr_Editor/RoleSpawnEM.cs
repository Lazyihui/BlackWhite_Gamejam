using System;
using UnityEngine;

namespace BW {


    [ExecuteInEditMode]
    public class RoleSpawnEM : MonoBehaviour {

        public RoleSpawnTM spawnTM;

        void Update() {


            var so = spawnTM.so;
            if (so == null) {
                return;
            }

            var tm = so.tm;
            string n = "Role_Entity_" + tm.typeName;

        }

        [ContextMenu("Save")]
        public void Save() {
            Debug.Log("Save_RoleSpawn");
            spawnTM.position = transform.position;
            spawnTM.rotation = transform.rotation.eulerAngles;
        }

    }
}