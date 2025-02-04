using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBlue : MonoBehaviour
{
    public GameObject turret;

    public Color blue;
    public Color red;

    // Pour le renderer
    private Renderer rend;

    private BuildManager buildManager;

    private void Start()
    {
        rend = GetComponent<Renderer>();
        rend.material.color = blue;

        buildManager = BuildManager.Instance;
    }

    private void OnMouseDown()
    {
        if(!buildManager.canBuild)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("Impossible de construire ici !");
                return;
        }

        buildManager.BuildTurretOn(this);
    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("BlueBullet") && rend.material.color == red)
        {
            Debug.Log("+1 blue");
            GameManager.bluePoint += 1;
            rend.material.color = blue;
            transform.tag = "NodeBlue";
            Destroy(collision.gameObject);
        }

        if (collision.transform.CompareTag("BlueBullet2") && rend.material.color == red)
        {
            Debug.Log("+1 blue");
            GameManager.bluePoint += 1;
            rend.material.color = blue;
            transform.tag = "NodeBlue";
        }

        if (collision.transform.CompareTag("BlueRocket") && rend.material.color == red)
        {
            Debug.Log("+1 blue");
            GameManager.bluePoint += 1;
            rend.material.color = blue;
            transform.tag = "NodeBlue";
            Destroy(collision.gameObject);
        }

        if (collision.transform.CompareTag("BlueLaser") && rend.material.color == red)
        {
            Debug.Log("+1 blue");
            GameManager.bluePoint += 1;
            rend.material.color = blue;
            transform.tag = "NodeBlue";
        }

        if (collision.transform.CompareTag("RedBullet") && rend.material.color == blue)
        {
            Debug.Log("-1 blue");
            GameManager.bluePoint -= 1;
            rend.material.color = red;
            transform.tag = "NodeRed";
            Destroy(collision.gameObject);
        }

        if (collision.transform.CompareTag("RedBullet2") && rend.material.color == blue)
        {
            Debug.Log("-1 blue");
            GameManager.bluePoint -= 1;
            rend.material.color = red;
            transform.tag = "NodeRed";
        }

        if (collision.transform.CompareTag("RedRocket") && rend.material.color == blue)
        {
            Debug.Log("-1 blue");
            GameManager.bluePoint -= 1;
            rend.material.color = red;
            transform.tag = "NodeRed";
            Destroy(collision.gameObject);
        }

        if (collision.transform.CompareTag("RedLaser") && rend.material.color == blue)
        {
            Debug.Log("-1 blue");
            GameManager.bluePoint -= 1;
            rend.material.color = red;
            transform.tag = "NodeRed";
        }
    }
}
