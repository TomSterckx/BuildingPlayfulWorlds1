using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SPAWN : MonoBehaviour {
    public GameObject prefab;
	// Use this for initialization
	void Start () {
            Instantiate(prefab, new Vector3(10, 10, 10), Quaternion.identity);
         
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
