using System;
using UnityEngine;

namespace BW {
    public class RoleEntity : MonoBehaviour {
        [SerializeField] Rigidbody2D rb;

        public int idSig;
        public int typeID;
        public float mvoeSpeed;

        public void Ctor() {

        }
        public void Move(Vector2 dir) {
            // TODO: Add speed
            rb.velocity = dir;
        }
    }
}