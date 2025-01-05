using System;
using UnityEngine;
using UnityEngine.UI;

namespace BW {
    [CreateAssetMenu(fileName = "AudioTM", menuName = "BW/AudioTM")]

    public class AudioTM : ScriptableObject {
        public string typeIDname;
        public AudioClip clip;

        public bool isLoop;
        public int typeID;
    }
}