using System.Collections;
using UnityEngine;

public class HandCollision : MonoBehaviour
{
    public GameObject image;

    private bool isColliding = false;

    private void OnParticleCollision(GameObject other)
    {
        if (other.CompareTag("water") && !isColliding)
        {
            Debug.Log("Colliding with water");

            // Set the flag to indicate that the hand is currently in contact with water
            isColliding = true;

            // Start the delay coroutine
            StartCoroutine(WaitAndNotify());
        }
    }

    private IEnumerator WaitAndNotify()
    {
        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Notify the FirstAidScript that the hand is in contact with water
        FirstAidScript firstAidScript = FindObjectOfType<FirstAidScript>();
        if (firstAidScript != null)
        {
            firstAidScript.SetHandInWater(true);
            image.SetActive(false);
        }

        // Reset the flag after notifying
        isColliding = false;
    }
}
