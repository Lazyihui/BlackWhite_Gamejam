using System;
using UnityEngine;

namespace BW {
    public class GameEntity {
        public float restFixTime;

        // Game
        public GameState state;
        public int stageCurID;

        public int ownerID;
        public int curMapID;

        public int flagIDRecord;


        public GameEntity() {

            restFixTime = 0;

            state = GameState.Login;
            stageCurID = 5;

            ownerID = 0;
            curMapID = 0;

            // TODO:
            flagIDRecord = 1;
        }

      

    }
}