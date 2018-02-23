using UnityEngine;

public class Gun : MonoBehaviour {

    public float damage = 10f;
    public float range = 100f;

    public Camera fpsCam;

    public ParticleSystem muzzleFlash;
    public GameObject impactEffect;
    public float impactForce = 30f;
    public float Ammo = 10;
    public float fireRate = 3f;
    public float nextTimeToFire = 0f; 

    void Update () {
		if (Input.GetButton("Fire1") && Ammo !=0 && Time.time>= nextTimeToFire)
        {
            nextTimeToFire = Time.time + 1f / fireRate;
            Shoot();
            Ammo -= 1;
        }
	}

    void Shoot () {
        muzzleFlash.Play();
        
        RaycastHit hit;
        if (Physics.Raycast(fpsCam.transform.position, fpsCam.transform.forward, out hit, range))
        {
            Debug.Log(hit.transform.name);

            Target target = hit.transform.GetComponent<Target>();
            if (target != null)
            {
                target.TakeDamage(damage);
                GameObject ImpactGO = Instantiate(impactEffect, hit.point, Quaternion.LookRotation(hit.normal));
                Destroy(ImpactGO, 2f);
            }

            if (hit.rigidbody != null)
            {
                hit.rigidbody.AddForce(-hit.normal * impactForce);
            }
        }
    }
}
