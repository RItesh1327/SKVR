using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class Module_3_Extinguisher : MonoBehaviour
{
    private Animator animator;

    private void Start()
    {
        // Get the Animator component attached to this GameObject
        animator = GetComponent<Animator>();

        // Ensure animator is not null before using it
        if (animator == null)
        {
            Debug.LogError("Animator component not found on " + gameObject.name);
        }
    }

    // Function to trigger the "press" animation (set bool to true)
    public void Press()
    {
        if (animator != null)
        {
            animator.SetBool("press", true);
        }
    }

    // Function to trigger the "release" animation (set bool to false)
    public void Release()
    {
        if (animator != null)
        {
            animator.SetBool("press", false);
        }
    }
}
