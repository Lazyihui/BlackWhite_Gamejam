using System;
using UnityEngine;

namespace BW {
    public static class RoleDomain {

        public static RoleEntity Spawn(GameContext ctx, int typeID) {
            RoleEntity role = GameFactory.Role_Create(ctx);
            role.typeID = typeID;
            ctx.roleRepository.Add(role);
            return role;
        }

        public static void Move(RoleEntity role, Vector2 dir) {
            role.Move(dir);
        }
        public static void Jump(GameContext ctx, RoleEntity role) {
            var input = ctx.inputCore;
            if (!input.isJumpKeyDown) {
                return;
            }
            role.Jump();
        }

        public static void GroundCheck(GameContext ctx, RoleEntity role) {

            // Physics2D.BoxCastAll();//向下发射一个射线，检测是否在地面上
            // Physics2D.OverlapCircleAll();//检测是否在地面上
            
            // Vector2 groundCheckPosition = role.Pos() + new Vector2(0, -0.5f);
            // float groundCheckRadius = 0.1f;
            // Collider2D[] colliders = Physics2D.OverlapCircleAll(groundCheckPosition, groundCheckRadius);
            // foreach (var collider in colliders) {
            //     if (collider.CompareTag("Ground")) {
            //         isCollideGound = true;
            //         break;
            //     }
            // }
            bool isCollideGound = false;

            if (role.Velocity().y > 0) {
                return;
            }

            Vector2 sixe = new Vector2(0.98f, 0.1f);
            float angle = 0;
            Vector2 dir = new Vector2(0, -1);
            RaycastHit2D[] hits = Physics2D.BoxCastAll(role.Pos(), sixe, angle, dir, 0.7f);
            Debug.DrawRay(role.Pos(), dir * 0.7f, Color.red);
            for (int i = 0; i < hits.Length; i += 1) {
                RaycastHit2D hit = hits[i];
                if (hit.collider.gameObject.CompareTag("Ground")) {
                    isCollideGound = true;
                    break;
                }
            }

            if (isCollideGound) {
                role.EnterGround();
            }
        }
    }
}