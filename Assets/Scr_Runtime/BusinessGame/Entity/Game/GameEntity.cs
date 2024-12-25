using System;
using UnityEngine;

namespace BW {
    public class GameEntity {
        public float restFixTime;
        public GameState state;

        public int ownerID;
        public int curMapID;

        public int flagIDRecord;


        public GameEntity() {

            restFixTime = 0;
            state = GameState.Login;

            ownerID = 0;
            curMapID = 0;

            // TODO:
            flagIDRecord = 1;
        }
    }
}