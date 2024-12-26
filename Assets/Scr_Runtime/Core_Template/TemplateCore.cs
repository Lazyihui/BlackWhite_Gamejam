using System;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;
using UnityEngine;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine.AddressableAssets;

namespace BW {

    public class TemplateCore {

        public Dictionary<int, AudioTM> audios;

        public AsyncOperationHandle audioHandle;

        public TemplateCore() {
            audios = new Dictionary<int, AudioTM>();
        }


        public async Task LoadAll() {
            {
                AssetLabelReference labelReference = new AssetLabelReference();

                labelReference.labelString = "AudioTM";
                var handle = Addressables.LoadAssetsAsync<AudioTM>(labelReference, null);

                var all = await handle.Task;
                foreach (var item in all) {
                    audios.Add(item.typeID, item);
                }

                audioHandle = handle;
            }
        }

        public void UnLoadAll() {
            if (audioHandle.IsValid()) {
                Addressables.Release(audioHandle);
            }
        }

    }

}