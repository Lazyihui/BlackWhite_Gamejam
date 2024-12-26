using System;
using UnityEngine;

namespace BW {
    public class AudioEntity : MonoBehaviour {

        [SerializeField] AudioSource audioSource;

        [SerializeField] AudioClip clipJump;

        [SerializeField] AudioClip clipBG;

        public int idSig;

        public int typeID;

        public void Ctor() {
            if (typeID == 1) {
                audioSource.clip = clipJump;
            } else if (typeID == 0) {
                audioSource.clip = clipBG;
            }
        }
        public void Init(bool loop) {
            audioSource.loop = loop;
            if (loop) {
                audioSource.Play();
            }
        }

        public void PlayAudio() {
            audioSource.Play();
        }

        public void TearDown() {
            GameObject.Destroy(gameObject);
        }

    }
}