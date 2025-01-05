using System;
using UnityEngine;

namespace BW {
    public static class RoleDomain {

        public static RoleEntity SpawnBySpawn(GameContext ctx, int typeID, RoleSpawnTM spawnTM) {
            RoleEntity role = GameFactory.Role_CreateBySpawn(ctx, spawnTM);
            role.typeID = typeID;
            ctx.roleRepository.Add(role);
            return role;
        }
        public static RoleEntity Spawn(GameContext ctx, int typeID) {
            RoleEntity role = GameFactory.Role_Create(ctx);
            role.typeID = typeID;
            ctx.roleRepository.Add(role);
            return role;
        }
        public static void UnSpawn(GameContext ctx, RoleEntity role) {
            ctx.roleRepository.Remove(role);
            role.TearDown();
        }

        public static void ClearAll(GameContext ctx) {
            int len = ctx.roleRepository.TakeAll(out RoleEntity[] roles);
            for (int i = 0; i < len; i++) {
                RoleEntity role = roles[i];
                UnSpawn(ctx, role);
            }
        }

        #region Move
        public static void Move(RoleEntity role, Vector2 dir) {
            role.Move(dir);
        }
        public static void Jump(GameContext ctx, RoleEntity role) {
            var input = ctx.inputCore;
            if (!input.isJumpKeyDown) {
                return;
            }
            if (!role.AllowJump()) {
                return;
            }
            role.Jump();
            AudioDoamin.PlayAudio(ctx, ctx.audioJump);
        }


        public static void GroundCheck(GameContext ctx, RoleEntity role) {

            bool isCollideGound = false;
            if (role.Velocity().y > 0) {
                return;
            }

            RaycastHit2D[] hits = Physics2D.RaycastAll(role.GetPos(), Vector2.down, 0.4f);

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

        public static void X_InGround(GameContext ctx, RoleEntity role) {
            Collider2D[] hits = Physics2D.OverlapPointAll(role.GetPos());

            for (int i = 0; i < hits.Length; i += 1) {
                Collider2D hit = hits[i];
                if (hit.gameObject.CompareTag("Ground")) {
                    role.FleeGround();
                    break;
                }
            }


        }

        public static void GroundCheck1(GameContext ctx, RoleEntity role) {

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

            //为什么可以贴着墙跳 :解决 加一个摩擦力（没用摩擦力）
            bool isCollideGound = false;

            if (role.Velocity().y > 0) {
                return;
            }

            Vector2 sixe = new Vector2(0.98f, 0.1f);
            float angle = 0;
            Vector2 dir = new Vector2(0, -1);
            RaycastHit2D[] hits = Physics2D.BoxCastAll(role.GetPos(), sixe, angle, dir, 0.4f);

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
        #endregion

        #region Check

        public static void TouchFlag(GameContext ctx, RoleEntity role) {
            Vector2 rolePos = role.GetPos();
            var game = ctx.gameEntity;

            int len = ctx.flagRepository.TakeAll(out FlagEntity[] flags);
            for (int i = 0; i < len; i += 1) {
                FlagEntity flag = flags[i];

                if (flag.isFlag) {

                    Vector2 flagPos = flag.GetPos();
                    float dis = Vector2.Distance(rolePos, flagPos);
                    if (dis < 0.5f) {
                        //  // TODO:要放到GameDomain里
                        if (game.stageCurID < game.maxStageID) {
                            Debug.Log("进入下一关游戏胜利");

                            role.StopMove();
                            ctx.uiApp.Panel_NextStage_Open();
                            game.state = GameState.NextStage;
                        } else {
                            Debug.Log("游戏胜利");
                            role.StopMove();
                            ctx.uiApp.Panel_GameOver_Open();
                            game.state = GameState.GameOver;

                        }
                        // 
                    }
                }
            }

        }

        #endregion

        public static void ChangeRole(GameContext ctx, RoleEntity role) {
            var input = ctx.inputCore;
            if (input.isKeyDownE) {
                Debug.Log("isKeyDownE");
                role.Toggle();
            }
        }

        // 简单粗暴的穿梭
        public static void Shuttleboundary(GameContext ctx, RoleEntity role) {
            Vector2 pos = role.GetPos();
            if (pos.x > 11f) {
                pos.x = -11f;
            } else if (pos.x < -11f) {
                pos.x = 11f;
            }
            role.SetPos(pos);
        }

        public static void SetLastDir(GameContext ctx, RoleEntity role) {
            var input = ctx.inputCore;
            Vector2 curDir = input.moveAxis;
            if (curDir != Vector2.zero) {
                role.lastDir = curDir;
            }
        }

        public static void ClearAll(GameContext ctx, RoleEntity role) {
            ctx.roleRepository.Clear();

        }

        public static void GamePause(GameContext ctx, RoleEntity role) {
            var input = ctx.inputCore;
            if (input.isKeyDownEsc) {
                Debug.Log("isKeyDownE");
                ctx.uiApp.Panel_GamePause_Open();
            }
        }
    }
}