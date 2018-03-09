using UnityEngine;

public class Blue : Portal
{
    // Refernce types
    private Portal portalScript;
    public Transform spawnPointFromRedPortal;

    /// <summary>
    /// Set spawn point.
    /// </summary>
    private void Awake()
    { 
        // Get the 'Portal'-Script.
        portalScript = GetComponent<Portal>();

        // Set the spawn point for blue portal.
        portalScript.SpawnPoint = spawnPointFromRedPortal;
    }
}