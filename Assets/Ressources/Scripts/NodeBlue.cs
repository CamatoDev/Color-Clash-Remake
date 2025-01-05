using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NodeBlue : MonoBehaviour
{
    private GameObject turret;
    public Vector3 positionOffset;

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
        if(buildManager.GetTurretToBuild() == null)
        {
            return;
        }

        if(turret != null)
        {
            Debug.Log("Impossible de construire ici !");
                return;
        }

        // Construction d'une tourelle
        GameObject turretToBuild = buildManager.GetTurretToBuild();
        turret = (GameObject)Instantiate(turretToBuild, transform.position + positionOffset, transform.rotation);

    }
    public void OnTriggerEnter(Collider collision)
    {
        if (collision.transform.CompareTag("BlueBullet") && rend.material.color == red)
        {
            Debug.Log("+1");
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
