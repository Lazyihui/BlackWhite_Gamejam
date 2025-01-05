using System;
using UnityEngine;
using TriInspector;

namespace BW {

    [Serializable]
    public class RoleTM {

        public string typeName;
        public int typeID;
        public float moveSpeed;

        [Title("Renderer")]
        public Sprite sprite;

    }

}