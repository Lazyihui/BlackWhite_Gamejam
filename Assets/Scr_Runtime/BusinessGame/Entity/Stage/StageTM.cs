using System;
using UnityEngine;

namespace BW {

    [Serializable]
    public class StageTM {
        public int stageID;
        public RoleSpawnTM[] roleSpawns;
        public FlagSpawnTM[] flagSpawns;

    }
}