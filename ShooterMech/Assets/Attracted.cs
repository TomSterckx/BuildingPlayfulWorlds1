using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attracted : MonoBehaviour {
    public GameObject attractedTo;
     
    public float radius = 1.0f;

    public float strengthOfAttraction = 2.0f;

	// Use this for initialization
	void Start () {
        
	}

    // Update is called once per frame
    void FixedUpdate()
    {
        Collider[] colliders = Physics.OverlapSphere(transform.position, radius);

        foreach (Collider nearbyObject in colliders)
        {
            Rigidbody rb = nearbyObject.GetComponent<Rigidbody>();
            if (rb != null)
            {
                Vector3 direction = attractedTo.transform.position - transform.position;
                rb.AddForce(strengthOfAttraction * direction);
            }
        }
    }
    
}
