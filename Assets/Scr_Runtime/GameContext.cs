using System;
using UnityEngine;

namespace BW {
    public class GameContext {
        public GameEntity gameEntity;
        // Core
        public AssetsCore assetsCore;
        // ropository
        public RoleRepository roleRepository;
        public GameContext() {
            gameEntity = new GameEntity();

            // Core
            assetsCore = new AssetsCore();

            // repositories
            roleRepository = new RoleRepository();
        }

        public void InJect() {

        }
    }

}