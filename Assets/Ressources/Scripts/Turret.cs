using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{
    // Variable pour le tire 
    public float fireRate = 1f;
    public float fireCountDonw = 0f;

    public GameObject bulletPrebab;
    public Transform firePoint;

    // Update is called once per frame
    void Update()
    {
        if(fireCountDonw <= 0)
        {
            Shoot();
            fireCountDonw = 1 / fireRate;
        }

        fireCountDonw -= Time.deltaTime;
    }

    void Shoot()
    {
        Instantiate(bulletPrebab, firePoint.position, firePoint.rotation);
    }
}
