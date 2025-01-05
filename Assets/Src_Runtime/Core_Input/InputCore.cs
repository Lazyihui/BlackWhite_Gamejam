using System;
using UnityEngine;

namespace BW {

    public class InputCore {
        public InputController_Player input_Role;
        public Vector2 moveAxis;

        public bool isJumpKeyDown;

        public bool isKeyDownE;

        public bool isKeyDownEsc;

        public bool isKeyDownR;

        public InputCore() {
            input_Role = new InputController_Player();
            input_Role.Enable();
            isJumpKeyDown = false;
        }

        public void Dispose() {
            input_Role.Disable();
        }

        public void Process() {
            var World = input_Role.World;

            // move
            {
                float kbxLeft = World.MoveLeft.ReadValue<float>();
                float kbxRight = World.MoveRight.ReadValue<float>();

                float kbxUp = World.MoveUp.ReadValue<float>();
                float kbxDown = World.MoveDown.ReadValue<float>();

                Vector2 axis = new Vector2(kbxRight - kbxLeft, kbxUp - kbxDown);
                moveAxis = axis;
            }

            // jump
            {
                float kbxk = World.Jump.ReadValue<float>();
                if (kbxk > 0) {
                    isJumpKeyDown = true;
                } else {
                    isJumpKeyDown = false;
                }
            }

            //PressE
            {

                // TODO: 还不太清楚如何使用 总结InputSystem的使用
                // bool kbxk = World.PressE.IsPressed();
                // Debug.Log("PressE:" + kbxk);
                // if (kbxk) {
                //     isKeyDownE = true;
                // } else {
                //     isKeyDownE = false;
                // }

                if (World.PressE.triggered) {
                    isKeyDownE = true;
                } else {
                    isKeyDownE = false;
                }

            }


            //PressEsc
            {
                if (World.PressEsc.triggered) {
                    isKeyDownEsc = true;
                } else {
                    isKeyDownEsc = false;
                }
            }

            // PressR
            {
                if (World.PressR.triggered) {
                    isKeyDownR = true;
                } else {
                    isKeyDownR = false;
                }
            }
        }
    }
}