using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HapticExample : MonoBehaviour {

        public AudioClip audioClip;
        OVRHapticsClip hapticsClip;

        void Start()
        {
            hapticsClip = new OVRHapticsClip(audioClip);
        }

    private void OnCollisionEnter(Collision other)
    {
        if (other.gameObject)
        {
            OVRHaptics.Mix(hapticsClip);
        }
    }
}

   