using UnityEngine;

public class BlueShop : MonoBehaviour
{
    public TurretBluePrint standardBlueTurretPrefab;
    public TurretBluePrint standardBlueTurretWithPanelPrefab;
    public TurretBluePrint BlueMissileLauncher;
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
        buildManager.SelectTurretToBuild(standardBlueTurretPrefab);
    }
    public void SelectStandardTurretWithPanel()
    {
        Debug.Log("Tourelle avec panel selectionn�.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(standardBlueTurretWithPanelPrefab);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("Tourelle Lance Missile selectionn�.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(BlueMissileLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Tourelle Laser selectionn�.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
