using System;
using UnityEngine;

namespace BW {
    public static class MapDomain {
        public static MapEntity Spawn(GameContext ctx, int stageID) {

            MapEntity map = GameFactory.Map_Create(ctx, stageID);

            ctx.mapRepository.Add(map);
            return map;
        }

        public static void UnSpawn(GameContext ctx, MapEntity map) {
            ctx.mapRepository.Remove(map);
            map.TearDown();
        }

        public static void ClearAll(GameContext ctx) {
            int len = ctx.mapRepository.TakeAll(out MapEntity[] maps);

            for (int i = 0; i < len; i++) {
                MapEntity map = maps[i];
                UnSpawn(ctx, map);
            }
        }
        public static void ChangeMap(GameContext ctx, MapEntity map) {
            var input = ctx.inputCore;

            if (input.isKeyDownE) {
                map.Toggle();
                input.isKeyDownE = false;
            }
        }

    }
}