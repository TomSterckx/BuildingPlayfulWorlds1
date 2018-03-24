using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public float numEnemies = 25;
    public GameObject Lightningorbprefab;
    public Vector3 center;
    public Vector3 size;


    void OnTriggerEnter(Collider other)
    {
        
        if (other.tag == "Player")
        {
            for (int i = 0; i < numEnemies; i++)
            {
                Vector3 pos = center + new Vector3(Random.Range(-size.x , size.x ), 3, Random.Range(-size.z , size.z ));
                Instantiate(Lightningorbprefab, pos, Quaternion.identity);
            }
            Debug.Log("TRIGGERED2");
            Destroy(gameObject);
        }

    }
}
