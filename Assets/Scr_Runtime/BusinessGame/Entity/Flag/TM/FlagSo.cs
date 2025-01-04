using System;
using UnityEngine;

namespace BW {

    [CreateAssetMenu(fileName = "FlagSo", menuName = "BW/So_Flag", order = 0)]
    public class FlagSo : ScriptableObject {
        public FlagTM tm;
    }
}