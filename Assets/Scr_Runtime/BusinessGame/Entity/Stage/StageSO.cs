using System;
using UnityEngine;


namespace BW {

    [CreateAssetMenu(fileName = "StageSO_", menuName = "BW/So_Stage_")]
    public class StageSO : ScriptableObject {
        public StageTM tm;
    }
}