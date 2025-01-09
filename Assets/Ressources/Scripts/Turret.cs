using Unity.VisualScripting;
using UnityEngine;

public class Turret : MonoBehaviour
{
    [Header("Use Bullets")]
    // Variable pour le tire de balles 
    public float fireRate = 1f;
    public float fireCountDonw = 0f;
    public GameObject bulletPrebab;


    [Header("Use Laser")]
    public bool useLaser;
    public bool blue;
    public bool red;
    public LineRenderer lineRenderer;
    public ParticleSystem laserImpactEffect;

    [Header("Unity setup fields")]

    public Vector3 rotation;
    public Vector3 maxHeight;
    public Transform firePoint;
    private void Start()
    {
        transform.rotation = Quaternion.Euler(rotation);
    }

    // Update is called once per frame
    void Update()
    {
        if (useLaser)
        {
            Laser();
            if(maxHeight.z < 20.5f && blue)
            {
                maxHeight.z += Time.deltaTime;
            }

            if(maxHeight.z > -20.5f && red)
            {
                maxHeight.z -= Time.deltaTime;
            }
        }
        else
        {
            if (fireCountDonw <= 0)
            {
                Shoot();
                fireCountDonw = 1 / fireRate;
            }

            fireCountDonw -= Time.deltaTime;
        }
    }

    void Shoot()
    {
        Instantiate(bulletPrebab, firePoint.position, firePoint.rotation);
    }

    void Laser()
    {
        laserImpactEffect.Play();

        Vector3 laserPosition = new Vector3(firePoint.position.x, firePoint.position.y, maxHeight.z);

        lineRenderer.SetPosition(0, firePoint.position);
        lineRenderer.SetPosition(1, laserPosition);

        Vector3 dir = firePoint.position - laserPosition;
        laserImpactEffect.transform.rotation = Quaternion.LookRotation(dir);
        laserImpactEffect.transform.position = laserPosition;
    }
}
