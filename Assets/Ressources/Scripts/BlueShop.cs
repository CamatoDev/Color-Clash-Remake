using UnityEngine;

public class BlueShop : MonoBehaviour
{
    public TurretBluePrint standardBlueTurretPrefab;
    public TurretBluePrint laserBeamer;

    private BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.Instance;
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Tourelle Standard selectionn�.");
        buildManager.SelectTurretToBuild(standardBlueTurretPrefab);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Tourelle Laser selectionn�.");
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
