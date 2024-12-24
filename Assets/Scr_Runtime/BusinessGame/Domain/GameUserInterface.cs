using System;
using UnityEngine;

namespace BW {

    public static class GameUserInterface {


        // TODO: 重构(不知道写在这里合不合适)
        public static void ChangeMapRole(GameContext ctx, MapEntity map, RoleEntity role) {
            var input = ctx.inputCore;

            if (input.isKeyDownE) {
                map.Toggle();
                role.Toggle();
                input.isKeyDownE = false;
            }
        }

    }
}