using UnityEngine;

public class Module_3_Mop : MonoBehaviour
{
    public float spillDecreaseRate = 0.5f; // Adjust the spill decrease rate per second

    private Rigidbody mopRigidbody;
    private Collider clothCollider;

    private void Start()
    {
        mopRigidbody = GetComponent<Rigidbody>();
        clothCollider = GetComponentInChildren<Collider>(); // Assumes the cloth is a child object

        if (mopRigidbody == null || clothCollider == null)
        {
            Debug.LogError("Missing Rigidbody or Collider components.");
        }
    }

    private void Update()
    {
        // Check if the mop is being moved
        if (IsMopMoving())
        {
            DecreaseSpill();
        }
    }

    private bool IsMopMoving()
    {
        // Check the magnitude of the mop's velocity
        return mopRigidbody.velocity.magnitude > 0.1f;
    }

    private void DecreaseSpill()
    {
        // Simulate spill decrease based on movement
        float spillDecrease = spillDecreaseRate * Time.deltaTime;
        // Assume you have a SpillManager or something to handle spill logic
        // Example: SpillManager.Instance.DecreaseSpill(spillDecrease);

        Debug.Log("Spill decreased: " + spillDecrease);
    }
}
