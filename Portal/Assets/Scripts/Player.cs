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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
                        InstantiatePortal
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
    /// Instantiate portal on the collider by hit with cursor.
    /// </summary>
    /// <param name="prefab">Instantiated game object.</param>
    /// <param name="posX">Position x for game object to instantiate.</param>
    /// <param name="posY">Position y for game object to instantiate.</param>
    /// <param name="posZ">Position z for game object to instantiate.</param>
    /// <param name="rotation">Completely rotation kit (x, y, z) for game object to instantiate.</param>
    void InstantiatePortal(GameObject prefab, float posX, float posY, float posZ, Quaternion rotation)
    {
        Instantiate(prefab, new Vector3(posX, posY, posZ), rotation);
    }
}