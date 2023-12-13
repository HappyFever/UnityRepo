using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public GameObject player;

    // Start is called before the first frame update
    void Start()
    {
        // Set the camera as a child of the player object
        transform.parent = player.transform;

        // Optionally, set the local position of the camera relative to the player
        transform.localPosition = new Vector3(0, 10, -20); // Example offset

        // Optionally, set the local rotation if needed
        transform.localRotation = Quaternion.Euler(20, 0, 0); // Example rotation
    }
}
