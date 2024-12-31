using System;
using UnityEngine;

namespace BW {
    public class GameContext {
        public GameEntity gameEntity;
        // Core
        public AssetsCore assetsCore;
        public TemplateCore templateCore;
        public InputCore inputCore;
        public UIApp uiApp;
        // ropository
        public RoleRepository roleRepository;
        public MapRepository mapRepository;
        public FlagRepository flagRepository;

        // audio
        public AudioEntity audioBG;
        public AudioEntity audioJump;


        public GameContext() {
            gameEntity = new GameEntity();

            // Core
            assetsCore = new AssetsCore();
            templateCore = new TemplateCore();
            inputCore = new InputCore();
            uiApp = new UIApp();

            // repositories
            roleRepository = new RoleRepository();
            mapRepository = new MapRepository();
            flagRepository = new FlagRepository();
        }

        public void InJect(Canvas canvas) {
            uiApp.Inject(assetsCore, canvas);
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