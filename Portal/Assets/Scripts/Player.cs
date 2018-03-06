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

        // hit.collider.transform
        if (Physics.Raycast(ray, out hit))
        {
            Debug.Log(hit.collider.name);

            if (Input.GetButtonDown("Fire1"))
            {
                Debug.Log("Spawn Collider");

                // Wall(3)
                Instantiate
                (
                    bluePortalPrefab,
                    new Vector3
                    (
                        mousePosition.x,
                        hit.collider.transform.position.y,
                        hit.collider.transform.position.z - 0.8f
                    ),
                    Quaternion.identity
                );
            }
        }
	}
}