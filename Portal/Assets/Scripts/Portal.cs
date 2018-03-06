using UnityEngine;

public class Portal : MonoBehaviour
{
    // Reference types
    public Transform spawnPoint;

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
                spawnPoint.position.x,
                spawnPoint.position.y,
                spawnPoint.position.z - 2f
            );

            // Rotate the game object in the correct direction.
            other.transform.Rotate
            (
                new Vector3
                (
                    other.transform.rotation.x,
                    other.transform.rotation.y + 180,
                    other.transform.rotation.z
                )
            );
        }
    }
}