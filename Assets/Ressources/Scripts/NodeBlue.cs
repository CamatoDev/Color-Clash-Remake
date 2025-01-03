using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBlue : MonoBehaviour
{
    public Color blue;
    public Color red;

    // Pour le renderer
    private Renderer rend;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = blue;
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("BlueBullet") && rend.material.color == red)
        {
            Debug.Log("OK");
            rend.material.color = blue;
            Destroy(collision.gameObject);
        }

        if (collision.transform.CompareTag("RedBullet") && rend.material.color == blue)
        {
            Debug.Log("OK");
            rend.material.color = red;
            Destroy(collision.gameObject);
        }
    }
}
