using System;
using UnityEngine;

namespace BW {
    public class RoleEntity : MonoBehaviour {
        [SerializeField] Rigidbody2D rb;

        public int idSig;
        public int typeID;
        public float moveSpeed;

        // jump 
        public int allowJumpTimes;
        public float jumpForce;

        public void Ctor() {
            moveSpeed = 5;
            allowJumpTimes = 0;
            // 决定跳跃高度
            jumpForce = 5;
        }

        public Vector2 GetPos() {
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

            // 面向
            if (dir.x > 0) {
                transform.localScale = new Vector3(1, 1, 1);
            } else if (dir.x < 0) {
                transform.localScale = new Vector3(-1, 1, 1);
            }
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