using System;
using UnityEngine;

namespace BW {

    public static class GameFactory {
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
            FlagEntity flag = GameObject.Instantiate(prefab).GetComponent<FlagEntity>();

            flag.Ctor();
            flag.idSig = ctx.gameEntity.flagIDRecord;

            flag.SetPos(pos);

            return flag;
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
    }
}