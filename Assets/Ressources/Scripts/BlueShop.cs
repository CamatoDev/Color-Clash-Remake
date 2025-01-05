using UnityEngine;

public class BlueShop : MonoBehaviour
{
    private BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.Instance;
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Tourelle Standard selectionné.");
        buildManager.SetTurretToBuild(buildManager.standardBlueTurretPrefab);
    }
}
