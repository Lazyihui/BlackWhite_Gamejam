using System;
using UnityEngine;

namespace BW {
    public static class RoleDomain {

        public static RoleEntity Spawn(GameContext ctx,int typeID) {
            RoleEntity role = GameFactory.Role_Create(ctx);
            role.typeID = typeID;
            ctx.roleRepository.Add(role);
            return role;
        }

        public static void Move(RoleEntity role, Vector2 dir) {
        }
    }
}