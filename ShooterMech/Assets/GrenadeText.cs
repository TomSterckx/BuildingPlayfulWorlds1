using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class GrenadeText : MonoBehaviour
{
    Text grenadeText;
    public GameObject GrenadeThrower;
    // Use this for initialization
    void Awake()
    {
        grenadeText = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        grenadeText.text = GrenadeThrower.GetComponent<GrenadeThrower>().currentAmmo.ToString();
    }
}
