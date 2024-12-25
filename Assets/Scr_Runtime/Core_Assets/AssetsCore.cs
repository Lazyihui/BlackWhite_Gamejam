using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;

namespace BW {


    public class AssetsCore {
        public Dictionary<string, GameObject> entities;

        public AsyncOperationHandle entitiesHandle;

        public Dictionary<string, GameObject> panels;

        public AsyncOperationHandle panelsHandle;

        public AssetsCore() {
            entities = new Dictionary<string, GameObject>();
            panels = new Dictionary<string, GameObject>();
        }


        public async Task LoadAll() {
            {
                AssetLabelReference labelReference = new AssetLabelReference();

                labelReference.labelString = "Entity";
                var handle = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);

                var all = await handle.Task;
                foreach (var item in all) {
                    entities.Add(item.name, item);
                }

                entitiesHandle = handle;
            }

            {
                AssetLabelReference labelReference = new AssetLabelReference();
                labelReference.labelString = "Panel";
                var handle = Addressables.LoadAssetsAsync<GameObject>(labelReference, null);

                var all = await handle.Task;

                foreach (var item in all) {
                    panels.Add(item.name, item);
                }

                panelsHandle = handle;
            }
        }


        public void UnLoadAll() {
            if (entitiesHandle.IsValid()) {
                Addressables.Release(entitiesHandle);
            }
            if (panelsHandle.IsValid()) {
                Addressables.Release(panelsHandle);
            }
        }
        // Entity
        public GameObject Entity_GetRole() {
            entities.TryGetValue("Entity_Role", out GameObject role);
            return role;
        }

        public GameObject Entity_GetFlag() {
            entities.TryGetValue("Entity_Flag", out GameObject flag);
            return flag;
        }

        public GameObject Entity_GetMap(int stageID) {
            entities.TryGetValue("Entity_Map_Variant_" + stageID, out GameObject map);
            Debug.Log("Entity_Map_Variant_" + stageID);
            return map;
        }

        // Panel
        public GameObject Panel_GetRestart() {
            panels.TryGetValue("Panel_Restart", out GameObject panel);
            return panel;
        }
    }
}