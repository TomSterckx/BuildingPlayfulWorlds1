using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour {

    public float health = 500f;


    public void TakeDamage(float amount)
    {
        
        if (health > 0f)
        {
            
            health -= amount;
        }
        else
        {
            Die();
        }
    }

    void Die()
    {
        Debug.Log("Rip mate");
        FindObjectOfType<GameManager>().EndGame();
     

    }
}
