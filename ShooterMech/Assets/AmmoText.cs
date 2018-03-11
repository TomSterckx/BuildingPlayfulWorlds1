using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class AmmoText : MonoBehaviour {
    Text ammoText;
    public GameObject gun; 
    // Use this for initialization
    void Awake () {
        ammoText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        ammoText.text = gun.GetComponent<Gun>().currentAmmo.ToString();
    }
}
