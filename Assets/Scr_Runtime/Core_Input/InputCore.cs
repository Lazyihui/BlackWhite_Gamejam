using System;
using UnityEngine;

namespace BW {

    public class InputCore {
        public InputController_Player input_Role;

        public InputCore() {
            input_Role = new InputController_Player();
            input_Role.Enable();
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
            }

        }
    }
}