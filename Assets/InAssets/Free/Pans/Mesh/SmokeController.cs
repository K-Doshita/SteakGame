using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SmokeController : MonoBehaviour {

    public ParticleSystem smoke;



	// Use this for initialization
	void Start () {
        smoke = GetComponent<ParticleSystem>();
        smoke.Stop();


    }


    // Update is called once per frame
    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "Pan")
        {
            smoke.Play();
        }
    }
}
