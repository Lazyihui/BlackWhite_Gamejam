using System;
using UnityEngine;


namespace BW {

    public static class FlagDomain {
        public static FlagEntity SpawnBySpawner(GameContext ctx, int typeID, FlagSpawnTM spawnTM) {
            FlagEntity flag = GameFactory.Flag_CreateBySpawner(ctx, spawnTM);
            flag.typeID = typeID;
            flag.isFlag = true;

            ctx.flagRepository.Add(flag);
            return flag;
        }

        public static FlagEntity Spawn(GameContext ctx, int typeID, Vector2 pos) {
            FlagEntity flag = GameFactory.Flag_Create(ctx, pos);
            flag.typeID = typeID;
            flag.isFlag = true;

            ctx.flagRepository.Add(flag);
            return flag;
        }
        public static void UnSpawn(GameContext ctx, FlagEntity flag) {
            ctx.flagRepository.Remove(flag);
            flag.TearDown();
        }

        public static void ClearAll(GameContext ctx) {
            int len = ctx.flagRepository.TakeAll(out FlagEntity[] flags);

            for (int i = 0; i < len; i++) {
                FlagEntity flag = flags[i];
                UnSpawn(ctx, flag);
            }
        }

    }
}