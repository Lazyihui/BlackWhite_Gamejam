using System;
using UnityEngine;

namespace BW {
    public class RoleEntity : MonoBehaviour {
        [SerializeField] Rigidbody2D rb;
        [SerializeField] GameObject roleWhite;
        [SerializeField] GameObject roleBlack;

        public int idSig;
        public int typeID;
        public float moveSpeed;

        // jump 
        public int allowJumpTimes;
        public float jumpForce;

        // 上一次的面向
        public Vector2 lastDir;

        public void Ctor() {
            moveSpeed = 5;
            allowJumpTimes = 0;
            // 决定跳跃高度
            jumpForce = 5;
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

        public Vector2 Velocity() {
            return rb.velocity;
        }

        public void SetPos(Vector2 pos) {
            transform.position = pos;
        }

        //TODO:觉得要用全局的变量来同时控制map和role的状态
        public void Toggle() {
            roleBlack.SetActive(!roleBlack.activeSelf);
            roleWhite.SetActive(!roleWhite.activeSelf);
        }

        // DOTO:写成底层的方法
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

        public void StopMove() {
            var velo = rb.velocity;
            velo.x = 0;
            rb.velocity = velo;
        }

        public void Jump() {

            Vector2 oldVelo = rb.velocity;
            oldVelo.y = jumpForce;
            rb.velocity = oldVelo;
            allowJumpTimes--;
        }

        public void EnterGround() {
            allowJumpTimes = 1;
        }

        public bool AllowJump() {
            return allowJumpTimes > 0;
        }

        public void FleeGround() {
            if (this.lastDir.x == 1) {
                this.transform.position += new Vector3(-1f, 0, 0);
            }
            if (this.lastDir.x == -1) {
                this.transform.position += new Vector3(1f, 0, 0);
            }

        }
        public void TearDown() {
            Destroy(gameObject);
        }
    }
}