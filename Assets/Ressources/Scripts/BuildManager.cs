using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using static UnityEngine.GraphicsBuffer;

public class BuildManager : MonoBehaviour
{
    #region Singleton
    public static BuildManager Instance;
    public void Awake()
    {
        if (Instance != null)
        {
            Debug.Log("Y'a déjà un BuildManager dans la scene");
        }
        Instance = this;
    }
    #endregion

    private TurretBluePrint turretToBuild;

    public bool canBuild { get { return turretToBuild != null; } }
    public void SelectTurretToBuild(TurretBluePrint turret)
    {
        turretToBuild = turret;
    }

    public void BuildTurretOn(NodeBlue node)
    {
        if(Player1Stats.blueTimer < turretToBuild.time)
        {
            Debug.Log("Impossible d'effectuer l'action !");
            return;
        }

        Player1Stats.blueTimer -= turretToBuild.time;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.transform.position + node.positionOffset, Quaternion.identity);
        node.turret = turret;
    }
    public void BuildTurretOn(NodeRed node)
    {
        if (Player2Stats.redTimer < turretToBuild.time)
        {
            Debug.Log("Impossible d'effectuer l'action !");
            return;
        }

        Player2Stats.redTimer -= turretToBuild.time;

        GameObject turret = (GameObject)Instantiate(turretToBuild.prefab, node.transform.position + node.positionOffset, Quaternion.identity);
        node.turret = turret;
    }
}
