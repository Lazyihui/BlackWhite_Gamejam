using System;
using UnityEngine;

namespace BW {
    public class FlagEntity : MonoBehaviour {

        public int idSig;
        public int typeID;

        public bool isFlag;
        public void Ctor() {

        }

        public void SetPos(Vector2 pos) {
            transform.position = pos;
        }

        public Vector2 GetPos() {
            return transform.position;
        }
    }
}