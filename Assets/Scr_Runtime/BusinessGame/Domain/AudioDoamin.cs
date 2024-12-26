using System;
using UnityEngine;

namespace BW {
    public static class AudioDoamin {
        public static AudioEntity Spawn(GameContext ctx, int typeID, bool loop) {

            AudioEntity entity = GameFactory.Audio_Create(ctx, typeID, loop);
            entity.typeID = typeID;
            return entity;
        }

        public static void UnSpawn(GameContext ctx, AudioEntity entity) {
            ctx.audioBG = null;
            ctx.audioJump = null;
            entity.TearDown();
        }

        public static void ClearAll(GameContext ctx) {
            if (ctx.audioBG != null) {
                UnSpawn(ctx, ctx.audioBG);
            }
            if (ctx.audioJump != null) {
                UnSpawn(ctx, ctx.audioJump);
            }
        }

        public static void PlayAudio(GameContext ctx, AudioEntity entity) {
            entity.PlayAudio();
        }
    }
}