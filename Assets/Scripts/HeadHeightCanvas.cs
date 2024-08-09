using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HeadHeightCanvas : MonoBehaviour
{
    public Transform playerHead; // Reference to the player's head/camera transform
    public Vector3 offset; // Offset from the player's head position

    void Update()
    {
        // Match the canvas's Y position with the player head's Y position, applying the offset
        transform.position = new Vector3(transform.position.x, playerHead.position.y + offset.y, transform.position.z);
    }
}
