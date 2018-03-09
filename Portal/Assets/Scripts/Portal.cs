using UnityEngine;

public class Portal : MonoBehaviour
{
    // Reference types
    private Transform spawnPoint;

    /// <summary>
    /// By trigger, then teleport the game object.
    /// </summary>
    /// <param name="other">The triggered game object.</param>
    private void OnTriggerEnter(Collider other)
    {
        // When the spawn point available, then spawn the game object in the other portal.
        if (spawnPoint != null)
            other.gameObject.transform.position = spawnPoint.position;
    }

    /// <summary>
    /// Set the spawn points from the respective portals.
    /// </summary>
    public Transform SpawnPoint
    {
        get { return spawnPoint; }
        set { spawnPoint = value; }
    }
}