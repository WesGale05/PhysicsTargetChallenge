using UnityEngine;

public class TargetMovement : MonoBehaviour
{
    [SerializeField] private float speed = 2f;       // Movement speed
    [SerializeField] private float distance = 3f;    // How far to move along X
    private Vector3 pointA;                         // Start position
    private Vector3 pointB;                         // End position

    void Start()
    {
        // Set the two points along the X axis
        pointA = new Vector3(transform.position.x - distance / 2f, transform.position.y, transform.position.z);
        pointB = new Vector3(transform.position.x + distance / 2f, transform.position.y, transform.position.z);
    }

    void Update()
    {
        // PingPong between 0 and 1 to reverse direction automatically
        float t = Mathf.PingPong(Time.time * speed, 1f);
        transform.position = Vector3.Lerp(pointA, pointB, t);
    }
}
