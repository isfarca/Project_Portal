using UnityEngine;

public class Portal : MonoBehaviour
{
    // Reference types
    private GameObject spawnPoint;

    /// <summary>
    /// By trigger, then teleport the game object.
    /// </summary>
    /// <param name="other">The triggered game object.</param>
    private void OnTriggerEnter(Collider other)
    {
        // When the spawn point available, then spawn the game object in the other portal.
        if (spawnPoint != null)
        {
            // Spawn the game object in the other portal.
            other.gameObject.transform.position = new Vector3
            (
                spawnPoint.transform.position.x,
                spawnPoint.transform.position.y,
                spawnPoint.transform.position.z
            );

            // Rotate the game object in the correct direction.
            other.transform.Rotate
            (
                new Vector3
                (
                    other.transform.rotation.x,
                    other.transform.rotation.y,
                    other.transform.rotation.z
                )
            );
        }
    }

    public GameObject SpawnPoint
    {
        get { return spawnPoint; }
        set { spawnPoint = value; }
    }
}