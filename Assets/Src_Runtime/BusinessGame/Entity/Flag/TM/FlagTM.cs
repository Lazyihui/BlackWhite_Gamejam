using System;
using UnityEngine;
using TriInspector;

namespace BW {

    [Serializable]
    public class FlagTM {
        public string typeName;
        public int typeID;

        [Title("Renderer")]
        public Sprite sprite;
    }

}