using System;
using UnityEngine;

namespace BW {
    public class RoleEntity : MonoBehaviour {
        [SerializeField] Rigidbody2D rb;

        public int idSig;
        public int typeID;
        public float moveSpeed;

        public bool isjump;

        public void Ctor() {
            moveSpeed = 5;
        }

        public void Move(Vector2 dir) {
            var velo = rb.velocity;
            float veloy = velo.y;
            velo.x = dir.x * moveSpeed;
            velo.y = veloy;
            rb.velocity = velo;
        }

        public void Jump() {
            if (isjump) {
                return;
            }
            isjump = true;
            rb.AddForce(Vector2.up * 10, ForceMode2D.Impulse);
        }
    }
}