using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GrenadeThrower : MonoBehaviour {

    public float throwForce = 30f;
    public GameObject grenadePrefab;
    public int maxAmmo = 10;
    public int currentAmmo = 10;

    void Start()
    {
        if (currentAmmo == -1)
        { currentAmmo = maxAmmo; }
    }
    // Update is called once per frame
    void Update () {
		if (Input.GetMouseButtonDown(1) && currentAmmo >= 1)
        {
            ThrowGrenade();
            currentAmmo--;
            Debug.Log("Kipje");
        }
	}
    void ThrowGrenade()
    {
        GameObject grenade = Instantiate(grenadePrefab, transform.position, transform.rotation);
        Rigidbody rb = grenade.GetComponent<Rigidbody>();
        rb.AddForce(transform.forward * throwForce, ForceMode.VelocityChange);
    }
}
