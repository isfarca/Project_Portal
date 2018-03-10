using UnityEngine;

public class Spin : MonoBehaviour
{
    // Value types
    public float speed = 100f;
	
	// Update is called once per frame
	void Update()
    {
        // Turn the gameobject in clockwise.
        transform.Rotate(Vector3.up, speed * Time.deltaTime);
    }
}
