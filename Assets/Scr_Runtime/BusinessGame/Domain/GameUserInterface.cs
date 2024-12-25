using System;
using UnityEngine;

namespace BW {

    public static class GameUserInterface {


        // TODO: 问： 重构(不知道写在这里合不合适)
        public static void ChangeMapRole(GameContext ctx, MapEntity map, RoleEntity role) {
            var input = ctx.inputCore;

            if (input.isKeyDownE) {
                map.Toggle();
                role.Toggle();
                input.isKeyDownE = false;
            }
        }

        // TODO: 重构 写在System里面
        public static void ClearAllGameDate(GameContext ctx) {
            var game = ctx.gameEntity;

            RoleDomain.ClearAll(ctx);
            FlagDomain.ClearAll(ctx);
            MapDomain.ClearAll(ctx);

        }

        public static void Restart(GameContext ctx) {
            // role
            RoleEntity role = ctx.Get_Role();
            role.SetPos(new Vector2(-10, -4f));

            // map
            MapEntity map = ctx.Get_Map();
            map.ReCtor();

        }

    }
}