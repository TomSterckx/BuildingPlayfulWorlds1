using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthText : MonoBehaviour {
    Text healthText;
    public GameObject player;

    // Use this for initialization
    void Awake () {
        healthText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        healthText.text = player.GetComponent<Health>().health.ToString();
    }
}
