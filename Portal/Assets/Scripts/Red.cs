using UnityEngine;

public class Red : Portal
{
    // Refernce types
    private Portal portalScript;
    private Blue blueScript;

    /// <summary>
    /// Set spawn point for portals.
    /// </summary>
    private void Awake()
    {
        // Get various components.
        portalScript = GetComponent<Portal>();
        blueScript = GetComponent<Blue>();

        SetSpawnPointBlue(); // Spawn point for blue portal.
        blueScript.SetSpawnPointRed(); // Spawn point for red portal.
    }

    /// <summary>
    /// Set spawn point for blue portal.
    /// </summary>
    public void SetSpawnPointBlue()
    {
        portalScript.SpawnPoint = GameObject.FindGameObjectWithTag("Blue");
    }
}