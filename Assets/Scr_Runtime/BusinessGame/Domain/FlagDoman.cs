using System;
using UnityEngine;


namespace BW {

    public static class FlagDomain {
        public static FlagEntity Spawn(GameContext ctx, int typeID, Vector2 pos) {
            FlagEntity flag = GameFactory.Flag_Create(ctx,pos);
            flag.typeID = typeID;
            flag.isFlag = true;
            return flag;
        }
    }
}