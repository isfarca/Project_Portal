using UnityEngine;

public class Portal : MonoBehaviour
{
    // Reference types
    public Transform spawnPoint;

    private void OnTriggerEnter(Collider other)
    {
        // When the spawn point available, then spawn the player in the other portal.
        if (spawnPoint != null)
        {
            // Spawn the player in the other portal:
            other.gameObject.transform.position = spawnPoint.position;

            // Rotate the player in the correct direction.
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