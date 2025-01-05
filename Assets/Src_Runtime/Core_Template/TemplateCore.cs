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


        public Dictionary<int, StageTM> stages;
        public AsyncOperationHandle stageHandle;

        public Dictionary<int, RoleTM> roles;
        public AsyncOperationHandle roleHandle;

        public Dictionary<int, FlagTM> flags;
        public AsyncOperationHandle flagHandle;


        public TemplateCore() {
            audios = new Dictionary<int, AudioTM>();
            stages = new Dictionary<int, StageTM>();
            roles = new Dictionary<int, RoleTM>();
            flags = new Dictionary<int, FlagTM>();
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
            {
                AssetLabelReference labelReference = new AssetLabelReference();

                labelReference.labelString = "So_Stage";
                var handle = Addressables.LoadAssetsAsync<StageSO>(labelReference, null);
                var all = await handle.Task;

                foreach (var so in all) {
                    var tm = so.tm;
                    stages.Add(tm.stageID, tm);
                }

                stageHandle = handle;
            }
            {
                AssetLabelReference labelReference = new AssetLabelReference();

                labelReference.labelString = "So_Role";
                var handle = Addressables.LoadAssetsAsync<RoleSO>(labelReference, null);
                var all = await handle.Task;

                foreach (var so in all) {
                    var tm = so.tm;
                    roles.Add(tm.typeID, tm);
                }

                roleHandle = handle;
            }
            {
                AssetLabelReference labelReference = new AssetLabelReference();

                labelReference.labelString = "So_Flag";
                var handle = Addressables.LoadAssetsAsync<FlagSo>(labelReference, null);
                var all = await handle.Task;

                foreach (var so in all) {
                    var tm = so.tm;
                    flags.Add(tm.typeID, tm);
                }

                flagHandle = handle;
            }

        }

        public bool TryGetStage(int stageID, out StageTM stage) {
            return stages.TryGetValue(stageID, out stage);
        }

        public void UnLoadAll() {
            if (audioHandle.IsValid()) {
                Addressables.Release(audioHandle);
            }
            if (stageHandle.IsValid()) {
                Addressables.Release(stageHandle);
            }
            if (roleHandle.IsValid()) {
                Addressables.Release(roleHandle);
            }
            if (flagHandle.IsValid()) {
                Addressables.Release(flagHandle);
            }
        }

    }

}