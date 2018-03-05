using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSpawn : MonoBehaviour {

    public GameObject enemy;
    public float rayCastRange= 3f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        RaycastHit hit;
        if (Physics.Raycast(transform.position + transform.up * 0.1f, -transform.up, out hit, rayCastRange))
        {
            
            Instantiate(enemy, transform.position , transform.rotation);
            Debug.Log("Hakuna Matata");
            Destroy(gameObject);

        }
    }

}
