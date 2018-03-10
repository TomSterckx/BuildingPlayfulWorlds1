using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideSpawn : MonoBehaviour {

    public GameObject enemy;
    public LayerMask ground;
    public float rayCastRange= 1f;
	void Start () {
		
	}
	
	

    private void OnCollisionEnter(Collision collision)
    {
        Instantiate(enemy, transform.position, Quaternion.identity);
        Debug.Log("Hakuna Matata");
        Destroy(gameObject);
    }

}
