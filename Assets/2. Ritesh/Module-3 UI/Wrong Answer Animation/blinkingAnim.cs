using UnityEngine;

public class blinkingAnim : MonoBehaviour
{
    private Animator animator;

    void Start()
    {
        animator = GetComponent<Animator>();
    }

    void Update()
    {
        // Trigger the animation when a certain condition is met.
       
    }

    void PlayBlinkingAnimation()
    {
        // Set the animation bool to true.
        animator.SetBool("IsBlinking", true);
    }

    // This function is called from the animation event.
    public void OnBlinkingAnimationEnd()
    {
        // Set the animation bool to false when the animation is finished.
        animator.SetBool("wrong", false);
    }
}
