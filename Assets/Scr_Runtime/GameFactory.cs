using System;
using UnityEngine;

namespace BW {

    public static class GameFactory {
        public static RoleEntity Role_CreateBySpawn(GameContext ctx, RoleSpawnTM spawnTM) {
            GameObject prefab = ctx.assetsCore.Entity_GetRole();
            if (prefab == null) {
                Debug.LogError("Role prefab is null");
            }
            RoleEntity role = GameObject.Instantiate(prefab).GetComponent<RoleEntity>();
            role.Ctor();
            role.idSig = ctx.gameEntity.ownerID;

            // spawmTM
            role.TF_Transfrom(spawnTM.position);
            Debug.Log("spawnTM.position: " + spawnTM.position);
            Debug.Log("spawnTM.rotation: " + spawnTM.rotation);
            role.TF_Rotation(spawnTM.rotation);


            return role;
        }
        public static RoleEntity Role_Create(GameContext ctx) {
            GameObject prefab = ctx.assetsCore.Entity_GetRole();
            if (prefab == null) {
                Debug.LogError("Role prefab is null");
            }
            RoleEntity role = GameObject.Instantiate(prefab).GetComponent<RoleEntity>();
            role.Ctor();
            role.idSig = ctx.gameEntity.ownerID;


            return role;
        }
        public static FlagEntity Flag_Create(GameContext ctx, Vector2 pos) {
            GameObject prefab = ctx.assetsCore.Entity_GetFlag();
            if (prefab == null) {
                Debug.LogError("Flag prefab is null");
            }
            FlagEntity entity = GameObject.Instantiate(prefab).GetComponent<FlagEntity>();

            entity.Ctor();
            entity.idSig = ctx.gameEntity.flagIDRecord++;

            entity.SetPos(pos);

            return entity;
        }

        public static MapEntity Map_Create(GameContext ctx, int stageID) {
            GameObject prefab = ctx.assetsCore.Entity_GetMap(stageID);
            if (prefab == null) {
                Debug.LogError("Map prefab is null");
            }
            MapEntity map = GameObject.Instantiate(prefab).GetComponent<MapEntity>();
            map.Ctor();
            // TODO: 这里不知道这样写对不对
            map.stageID = stageID;
            ctx.gameEntity.curMapID = map.stageID;

            return map;
        }

        public static AudioEntity Audio_Create(GameContext ctx, int typeID) {

            bool has = ctx.templateCore.audios.TryGetValue(typeID, out AudioTM tm);
            if (!has) {
                Debug.LogError("AudioTM not found");
            }
            GameObject prefab = ctx.assetsCore.Entity_GetAudio();
            AudioEntity entity = GameObject.Instantiate(prefab).GetComponent<AudioEntity>();

            entity.idSig = ctx.gameEntity.audioIDRecord++;
            entity.typeID = typeID;

            entity.SetClip(tm.clip, tm.isLoop);

            return entity;
        }
    }
}