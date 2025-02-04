using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float speed = 70f;

    public int damage = 10;

    private void Start()
    {

    }
    void Update()
    {
        if(transform.CompareTag("BlueBullet") || transform.CompareTag("BlueBullet2") || transform.CompareTag("RedBullet") || transform.CompareTag("RedBullet2"))
        {
            transform.position += transform.forward * speed * Time.deltaTime;
        }

        if(transform.CompareTag("BlueRocket") || transform.CompareTag("RedRocket"))
        {
            transform.position -= transform.right * speed * Time.deltaTime;
        }
    }
}
