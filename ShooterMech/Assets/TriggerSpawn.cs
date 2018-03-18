using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED");
        Destroy(gameObject);
    }
}
