using System;
using UnityEngine;

namespace BW {

    public class InputCore {
        public InputController_Player input_Role;
        public Vector2 moveAxis;

        public bool isJump;

        public InputCore() {
            input_Role = new InputController_Player();
            input_Role.Enable();
            isJump = false;
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
                float kbxJ = World.Jump.ReadValue<float>();
                if (kbxJ > 0) {
                    isJump = true;
                }
            }


        }
    }
}