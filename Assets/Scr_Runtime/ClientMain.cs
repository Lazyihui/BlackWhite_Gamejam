using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace BW {

    public class Main : MonoBehaviour {

        GameContext ctx;

        bool isTearDown = false;
        bool isInit = false;
        void Awake() {
            Debug.Log("Main Awake");

            // Init
            ctx = new GameContext();
            // Canvas screenCanvas = GameObject.Find("ScreenCanvas").GetComponent<Canvas>();
            // Canvas worldCanvas = GameObject.Find("WorldCanvas").GetComponent<Canvas>();

            // Binding
            Binding();

            Action action = async () => {

                await ctx.assetsCore.LoadAll();

                isInit = true;

                // GameEnter;
                Game_Business.Enter(ctx);
            };

            action.Invoke();

        }

        void Binding() {

        }

        void Update() {

            if(!isInit){
                return;
            }

            float dt = Time.deltaTime;

            // Input
            ctx.inputCore.Process();

            Game_Business.Tick(ctx, dt);

        }


        void OnDestroy() {
            TearDown();
        }

        void ApplciationQuit() {
            TearDown();
        }

        void TearDown() {
            if (isTearDown) {
                return;
            }
            isTearDown = true;
            ctx.assetsCore.UnLoadAll();

        }

    }
}
