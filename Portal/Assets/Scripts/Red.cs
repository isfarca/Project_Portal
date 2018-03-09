using UnityEngine;

public class Red : Portal
{
    // Refernce types
    private Portal portalScript;
    public Transform spawnPointFromBluePortal;

    /// <summary>
    /// Set spawn point.
    /// </summary>
    private void Awake()
    {
        // Get the 'Portal'-Script.
        portalScript = GetComponent<Portal>();

        // Set the spawn point for red portal.
        portalScript.SpawnPoint = spawnPointFromBluePortal;
    }
}