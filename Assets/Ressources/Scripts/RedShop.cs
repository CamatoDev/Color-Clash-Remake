using UnityEngine;

public class RedShop : MonoBehaviour
{
    public TurretBluePrint standardRedTurretPrefab;
    public TurretBluePrint laserBeamer;

    private BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.Instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Tourelle Standard selectionn�.");
        buildManager.SelectTurretToBuild(standardRedTurretPrefab);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Tourelle Laser selectionn�.");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
