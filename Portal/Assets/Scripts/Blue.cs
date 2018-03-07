using UnityEngine;

public class Blue : Portal
{
    // Refernce types
    private Portal portalScript;
    private Red redScript;

    /// <summary>
    /// Set spawn point for portals.
    /// </summary>
    private void Awake()
    { 
        // Get various components.
        portalScript = GetComponent<Portal>();
        redScript = GetComponent<Red>();

        // Set spawn points.
        SetSpawnPointRed(); // Spawn point for blue portal.
        redScript.SetSpawnPointBlue(); // Spawn point for red portal.
    }

    /// <summary>
    /// Set spawn point for blue portal.
    /// </summary>
    public void SetSpawnPointRed()
    {
        portalScript.SpawnPoint = GameObject.FindGameObjectWithTag("Red");
    }
}