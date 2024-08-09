using UnityEngine;

public class RelativeHoverScript : MonoBehaviour
{
    public float hoverHeight = 1.0f; // Adjust this value to set the hover height
    public float hoverSpeed = 1.0f; // Adjust this value to set the hover speed

    private Vector3 initialPosition;

    private void Start()
    {
        // Store the initial position
        initialPosition = transform.position;
    }

    private void Update()
    {
        // Calculate the new Y position for hovering relative to the initial position
        float newY = initialPosition.y + Mathf.Sin(Time.time * hoverSpeed) * hoverHeight;

        // Apply the new position to the GameObject
        transform.position = new Vector3(transform.position.x, newY, transform.position.z);
    }
}
