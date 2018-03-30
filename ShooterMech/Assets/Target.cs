using UnityEngine;

public class Target : MonoBehaviour {

    public float health = 50f;
    public GameObject explosionEffect;

    public void TakeDamage(float amount)
    {
        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }

    void Die ()
    {   if (gameObject.tag == "Balls")
        {
            FindObjectOfType<GameManager>().amountBalls++;
        }
        
        Instantiate(explosionEffect, transform.position, transform.rotation);
        Destroy(gameObject);




    }
}

