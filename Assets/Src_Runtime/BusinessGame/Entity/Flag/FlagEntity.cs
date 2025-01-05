using System;
using UnityEngine;

namespace BW {
    public class FlagEntity : MonoBehaviour {

        [SerializeField] Material mat;

        public int idSig;
        public int typeID;

        public bool isFlag;

        // Renderer
        public float fadeSpeed =1;
        public void Ctor() {

        }

        void Update(){
            float dt = Time.deltaTime;

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