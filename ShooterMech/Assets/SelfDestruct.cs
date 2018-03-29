using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelfDestruct : MonoBehaviour {
    public float delay = 5f;
    float countdown;
    // Use this for initialization
    void Start () {
        countdown = delay;

    }
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <= 0f )
        {
            Destroy(gameObject);
        }
    }
}
