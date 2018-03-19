using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSpawn : MonoBehaviour
{
    public float numEnemies = 5;
    public GameObject Enemyprefab;
    public Vector3 center;
    public Vector3 size;


    void OnTriggerEnter(Collider other)
    {
        Debug.Log("TRIGGERED");
        for (int i=0; i< numEnemies; i++)
        {
            Vector3 pos = center + new Vector3(Random.Range(-size.x/2, size.x/2), 0, Random.Range(-size.z / 2, size.z / 2));
            Instantiate(Enemyprefab, pos, Quaternion.identity);
        }

        Destroy(gameObject);
    }
}
