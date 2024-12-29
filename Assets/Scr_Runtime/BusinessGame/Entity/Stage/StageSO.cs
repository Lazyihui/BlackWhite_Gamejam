using System;
using UnityEngine;


namespace BW {

    [CreateAssetMenu(fileName = "StageSO_", menuName = "BW/StageSO")]
    public class StageSO : ScriptableObject {
        public StageTM tm;
    }
}