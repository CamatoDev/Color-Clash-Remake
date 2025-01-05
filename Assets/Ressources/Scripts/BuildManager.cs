using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public GameObject standardBlueTurretPrefab;
    public GameObject standardRedTurretPrefab;

    private GameObject turretToBuild;

    public GameObject GetTurretToBuild()
    {
        return turretToBuild;
    }

    public void SetTurretToBuild(GameObject turret)
    {
        turretToBuild = turret;
    }
}
