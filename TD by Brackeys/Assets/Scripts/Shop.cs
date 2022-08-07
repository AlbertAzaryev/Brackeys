
using UnityEngine;

public class Shop : MonoBehaviour
{
    public TurretBlueprint standartTurret;
    public TurretBlueprint missileLauncher;
    public TurretBlueprint laserBeamer;
    BuildManager buildManager;
    private void Start()
    {
        buildManager = BuildManager.instance;  
    }
    public void SelectStandartTurret()
        {
            Debug.Log("Standart Turret Selected");
            buildManager.SelectTurretBuild(standartTurret);
        }
    public void SelectMissilelauncher()
    {
        Debug.Log("Missel Launcher Selected");
        buildManager.SelectTurretBuild(missileLauncher);
    }
    public void SelectLaserBeamer()
    {
        Debug.Log("Laser Beamer Selected");
        buildManager.SelectTurretBuild(laserBeamer);
    }

}
