using System;
using UnityEngine;

namespace BW {
    public class FlagEntity : MonoBehaviour {

        public int idSig;
        public int typeID;

        public bool isFlag;
        public void Ctor() {

        }


        public void TF_Transfrom(Vector3 pos) {
            transform.position = pos;
        }

        public void TF_Rotation(Vector3 v) {
            transform.rotation = Quaternion.Euler(v);
        }

        public Vector2 GetPos() {
            return transform.position;
        }

        public void TearDown() {
            Destroy(gameObject);
        }
    }
}