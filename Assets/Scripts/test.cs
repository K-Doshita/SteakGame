using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

public class test : MonoBehaviour {

    // Use this for initialization
    //public AnimationClip Info;

    public static float GetAnimationClipLength(Animator animator, string Steak )
    {

        float clipLength = 0f;

        var rac = animator.runtimeAnimatorController;
        var clips = rac.animationClips.Where(x => x.name == Steak);
        foreach (var clip in clips)
        {
            clipLength = clip.length;
        }
        return clipLength;

    }


    void Start () {
        //Info = AnimationClip("Steak");
        DontDestroyOnLoad(this);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
