using System;
using UnityEngine;

namespace BW {

    public static class GameFactory {
        public static RoleEntity Role_Create(GameContext ctx) {

            GameObject prefab = ctx.assetsCore.Entity_GetRole();
            if(prefab == null){
                Debug.LogError("Role prefab is null");
            }

            RoleEntity role = GameObject.Instantiate(prefab).GetComponent<RoleEntity>();
            role.Ctor();
            return role;
        }
    }
}