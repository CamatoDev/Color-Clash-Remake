using UnityEngine;

public class RedShop : MonoBehaviour
{
    public TurretBluePrint standardRedTurretPrefab;
    public TurretBluePrint standardRedTurretWithPanelPrefab;
    public TurretBluePrint RedMissileLauncher;
    public TurretBluePrint laserBeamer;

    private BuildManager buildManager;
    private AudioSource audioSource;
    private void Start()
    {
        buildManager = BuildManager.Instance;
        audioSource = gameObject.GetComponent<AudioSource>();
    }
    public void SelectStandardTurret()
    {
        Debug.Log("Tourelle Standard selectionn�.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(standardRedTurretPrefab);
    }
    public void SelectStandardWithPanelTurret()
    {
        Debug.Log("Tourelle avec panel selectionn�.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(standardRedTurretWithPanelPrefab);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("Tourelle Lance Missile selectionn�.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(RedMissileLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Tourelle Laser selectionn�.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
