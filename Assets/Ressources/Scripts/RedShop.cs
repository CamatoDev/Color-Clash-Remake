using UnityEngine;

public class RedShop : MonoBehaviour
{
    private BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.Instance;
    }
    public void PurchaseStandardTurret()
    {
        Debug.Log("Tourelle Standard selectionn�.");
        buildManager.SetTurretToBuild(buildManager.standardRedTurretPrefab);
    }
}
