using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraShader : MonoBehaviour {

    [SerializeField] Material mat;

    float num = 1;

    void Update() {

        if (num < 0) {
            return;
        }

        float dt = Time.deltaTime;

        Debug.Log(num);
        num -= dt ;

        if (num < 0) {
            num = 0;
        }

        mat.SetFloat("_BuildingOffset", num);


    }
}
