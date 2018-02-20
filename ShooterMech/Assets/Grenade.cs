﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grenade : MonoBehaviour {

    public float delay = 3f;

    float countdown;
    bool hasExploded = false;
    public GameObject explosionEffect;
    public float radius = 5f;
    public float explosionForce = 700f;
    public AudioClip audioclip;

    void Start () {
        countdown = delay;
	}
	
	// Update is called once per frame
	void Update () {
        countdown -= Time.deltaTime;
        if (countdown <=0f && !hasExploded)
        {
            Explode();
            hasExploded = true;
        }
	}
    void Explode()
    {
        
        Instantiate(explosionEffect, transform.position, transform.rotation);

        AudioSource.PlayClipAtPoint(audioclip, transform.position);

        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.AddExplosionForce(explosionForce, transform.position, radius);
            }
        }
        
        Destroy(gameObject);
       
    }
}
