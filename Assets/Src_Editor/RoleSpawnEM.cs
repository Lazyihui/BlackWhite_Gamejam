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
            if (gameObject.name != n) {
                gameObject.name = n;
            }

            // 如果图片不存在报错
            if (tm.sprite == null) {
                Debug.LogError($"BuildingSpawnerEM {name}: tm.sprite is null");
                return;
            }

            SpriteRenderer sr = GetComponent<SpriteRenderer>();
            if (sr == null) {
                // 如果没有spriteRenderer就添加一个
                sr = gameObject.AddComponent<SpriteRenderer>();
            }

            sr.sprite = tm.sprite;
            sr.sortingOrder = 0;

        }

        [ContextMenu("Save")]
        public void Save() {
            Debug.Log("Save_RoleSpawn");
            spawnTM.position = transform.position;
            spawnTM.rotation = transform.rotation.eulerAngles;
        }

    }
}