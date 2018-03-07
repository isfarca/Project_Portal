using UnityEngine;

public class Player : MonoBehaviour
{
    // Reference types
    private Ray ray;
    private RaycastHit hit;
    public GameObject bluePortalPrefab;
    public GameObject redPortalPrefab;

    // Update is called once per frame
    void Update()
    {
        // Declare variables
        var mousePosition = Camera.main.ScreenToWorldPoint(Input.mousePosition); // Set the position of cursor in the scene.

        // Set ray to the cursor position.
        ray = Camera.main.ScreenPointToRay(Input.mousePosition);

        // Check the cursor show collider.
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.name);

            // Press mouse button left, then spawn the blue portal on the collider by hit with cursor.
            if (Input.GetButtonDown("Fire1"))
            {
                if (bluePortalPrefab != null)
                {
                    if (hit.collider.name == "Wall")
                    {
                        TransformPortal
                        (
                            bluePortalPrefab,
                            hit.collider.transform.position.x + 0.8f,
                            hit.collider.transform.position.y - 5f,
                            mousePosition.z,
                            Quaternion.Euler(0f, -90f, 0f)
                        );
                    }
                    else if (hit.collider.name == "Wall (1)")
                    {
                        TransformPortal
                        (
                            bluePortalPrefab,
                            hit.collider.transform.position.x - 0.8f,
                            hit.collider.transform.position.y - 5f,
                            mousePosition.z,
                            Quaternion.Euler(0f, 90f, 0f)
                        );
                    }
                    else if (hit.collider.name == "Wall (2)")
                    {
                        TransformPortal
                        (
                            bluePortalPrefab,
                            mousePosition.x,
                            hit.collider.transform.position.y - 5f,
                            hit.collider.transform.position.z + 0.8f,
                            Quaternion.Euler(0f, 180f, 0f)
                        );
                    }
                    else if (hit.collider.name == "Wall (3)")
                    {
                        TransformPortal
                        (
                            bluePortalPrefab,
                            mousePosition.x,
                            hit.collider.transform.position.y - 5f,
                            hit.collider.transform.position.z - 0.8f,
                            Quaternion.identity
                        );
                    }
                    else if (hit.collider.name == "Roof")
                    {
                        TransformPortal
                        (
                            bluePortalPrefab,
                            mousePosition.x,
                            hit.collider.transform.position.y - 0.8f,
                            hit.collider.transform.position.z,
                            Quaternion.Euler(-90f, 0f, 0f)
                        );
                    }
                }
            }
            // Press mouse button right, then spawn the red portal on the collider by hit with cursor.
            else if (Input.GetButtonDown("Fire2"))
            {
                if (redPortalPrefab != null)
                {
                    if (hit.collider.name == "Wall")
                    {
                        TransformPortal
                        (
                            redPortalPrefab,
                            hit.collider.transform.position.x + 0.8f,
                            hit.collider.transform.position.y - 5f,
                            mousePosition.z,
                            Quaternion.Euler(0f, -90f, 0f)
                        );
                    }
                    else if (hit.collider.name == "Wall (1)")
                    {
                        TransformPortal
                        (
                            redPortalPrefab,
                            hit.collider.transform.position.x - 0.8f,
                            hit.collider.transform.position.y - 5f,
                            mousePosition.z,
                            Quaternion.Euler(0f, 90f, 0f)
                        );
                    }
                    else if (hit.collider.name == "Wall (2)")
                    {
                        TransformPortal
                        (
                            redPortalPrefab,
                            mousePosition.x,
                            hit.collider.transform.position.y - 5f,
                            hit.collider.transform.position.z + 0.8f,
                            Quaternion.Euler(0f, 180f, 0f)
                        );
                    }
                    else if (hit.collider.name == "Wall (3)")
                    {
                        TransformPortal
                        (
                            redPortalPrefab,
                            mousePosition.x,
                            hit.collider.transform.position.y - 5f,
                            hit.collider.transform.position.z - 0.8f,
                            Quaternion.identity
                        );
                    }
                    else if (hit.collider.name == "Roof")
                    {
                        TransformPortal
                        (
                            redPortalPrefab,
                            mousePosition.x,
                            hit.collider.transform.position.y - 0.8f,
                            hit.collider.transform.position.z,
                            Quaternion.Euler(-90f, 0f, 0f)
                        );
                    }
                }
            }
        }
	}

    /// <summary>
    /// Transform portal on the collider by hit with cursor.
    /// </summary>
    /// <param name="prefab">Transformed game object.</param>
    /// <param name="posX">Position x for game object to transform.</param>
    /// <param name="posY">Position y for game object to transform.</param>
    /// <param name="posZ">Position z for game object to transform.</param>
    /// <param name="rotation">Completely rotation kit (x, y, z) for game object to transform.</param>
    void TransformPortal(GameObject prefab, float positionX, float positionY, float positionZ, Quaternion rotation)
    {
        // Set the position from current portal.
        prefab.transform.position = new Vector3(positionX, positionY, positionZ);

        // Set the rotation from current portal.
        prefab.transform.rotation = rotation;
    }
}