using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public void OnCollisionEnter(Collision collision)
    {
        if(collision.transform.CompareTag("BlueBullet") || collision.transform.CompareTag("BlueBullet2") || collision.transform.CompareTag("BlueRocket"))
        {
            Destroy(collision.gameObject);
        }

        if(collision.transform.CompareTag("RedBullet") || collision.transform.CompareTag("RedBullet")  || collision.transform.CompareTag("RedRocket"))
        {
            Destroy(collision.gameObject);
        }
    }
}
