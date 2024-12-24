using System;
using UnityEngine;

namespace BW {
    public class GameContext {
        public GameEntity gameEntity;
        // Core
        public AssetsCore assetsCore;
        public InputCore inputCore;
        // ropository
        public RoleRepository roleRepository;
        public FlagRepository flagRepository;
        public GameContext() {
            gameEntity = new GameEntity();

            // Core
            assetsCore = new AssetsCore();
            inputCore = new InputCore();

            // repositories
            roleRepository = new RoleRepository();
            flagRepository = new FlagRepository();
        }

        public void InJect() {

        }

        public RoleEntity Get_Role() {
            roleRepository.TryGet(gameEntity.ownerID, out RoleEntity role);
            return role;
        }
    }

}