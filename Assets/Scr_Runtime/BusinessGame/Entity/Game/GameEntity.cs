using System;
using UnityEngine;

namespace BW {
    public class GameEntity {
        public float restFixTime;

        public int ownerID;
        public int curMapID;

        public int flagIDRecord;

        public GameEntity() {
            restFixTime = 0;
            ownerID = 0;
            curMapID = 0;

            // TODO:
            flagIDRecord = 1;
        }
    }
}