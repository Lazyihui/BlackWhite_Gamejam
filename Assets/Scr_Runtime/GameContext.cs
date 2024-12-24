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
        public MapRepository mapRepository;
        public FlagRepository flagRepository;

        public GameContext() {
            gameEntity = new GameEntity();

            // Core
            assetsCore = new AssetsCore();
            inputCore = new InputCore();

            // repositories
            roleRepository = new RoleRepository();
            mapRepository = new MapRepository();
            flagRepository = new FlagRepository();
        }

        public void InJect() {

        }

        public RoleEntity Get_Role() {
            roleRepository.TryGet(gameEntity.ownerID, out RoleEntity role);
            return role;
        }

        public MapEntity Get_Map() {
            mapRepository.TryGet(gameEntity.curMapID, out MapEntity map);
            return map;
        }
    }

}