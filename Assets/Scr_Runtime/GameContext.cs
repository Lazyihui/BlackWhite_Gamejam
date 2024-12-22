using System;
using UnityEngine;

namespace BW {
    public class GameContext {
        // Core

        public AssetsCore assetsCore;
        // ropository
        public RoleRepository roleRepository;
        public GameContext() {
            // Core
            assetsCore = new AssetsCore();

            // repositories
            roleRepository = new RoleRepository();
        }

        public void InJect(){
            
        }
    }

}