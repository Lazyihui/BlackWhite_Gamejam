using System;
using UnityEngine;

namespace BW {
    public class RoleEntity : MonoBehaviour {
        [SerializeField] Rigidbody2D rb;

        public int idSig;
        public int typeID;
        public float moveSpeed;

        public bool isjump;

        public bool isAllowJump;

        public int allowJumpTimes;

        public float jumpForce;

        public void Ctor() {
            moveSpeed = 5;
            isAllowJump = false;
            allowJumpTimes = 0;
            jumpForce = 10;
        }

        public Vector2 Pos() {
            return transform.position;
        }

        public Vector2 Velocity() {
            return rb.velocity;
        }



        public void Move(Vector2 dir) {
            var velo = rb.velocity;
            float veloy = velo.y;
            velo.x = dir.x * moveSpeed;
            velo.y = veloy;
            rb.velocity = velo;
        }



        public void Jump() {
            if (!AllowJump()) {
                return;
            }
            Vector2 oldVelo = rb.velocity;
            oldVelo.y = jumpForce;
            rb.velocity = oldVelo;
            allowJumpTimes--;

        }

        public void EnterGround() {
            allowJumpTimes = 1;
        }
        bool AllowJump() {
            return allowJumpTimes > 0;
        }
    }
}