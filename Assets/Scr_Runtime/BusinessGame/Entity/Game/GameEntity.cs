using System;
using UnityEngine;

namespace BW {
    public class GameEntity {
        public float restFixTime;

        public int ownerID;

        public int FlagIDRecord;

        public GameEntity() {
            restFixTime = 0;
            ownerID = 0;

            // TODO:
            FlagIDRecord = 0;
        }
    }
}