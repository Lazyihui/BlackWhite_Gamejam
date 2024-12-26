using System;
using UnityEngine;

namespace BW {
    public class AudioEntity : MonoBehaviour {

        [SerializeField] AudioSource audioSource;

        public int idSig;

        public int typeID;

        public void SetClip(AudioClip clip, bool isLoop) {
            audioSource.clip = clip;
            audioSource.loop = isLoop;
        }

        public void Play() {
            audioSource.Play();
        }

        public void TearDown() {
            GameObject.Destroy(gameObject);
        }

    }
}