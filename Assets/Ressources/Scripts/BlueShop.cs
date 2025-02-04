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
        Debug.Log("Tourelle Standard selectionné.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(standardBlueTurretPrefab);
    }
    public void SelectStandardTurretWithPanel()
    {
        Debug.Log("Tourelle avec panel selectionné.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(standardBlueTurretWithPanelPrefab);
    }
    public void SelectMissileLauncher()
    {
        Debug.Log("Tourelle Lance Missile selectionné.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(BlueMissileLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Tourelle Laser selectionné.");
        audioSource.Play();
        buildManager.SelectTurretToBuild(laserBeamer);
    }
}
