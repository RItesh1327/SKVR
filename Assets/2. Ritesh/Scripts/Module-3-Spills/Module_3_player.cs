using UnityEngine;

public class Module_3_player : MonoBehaviour
{
    // Reference to the UIManager script
    public Module_3_UI_SpillBehaviour1 uiManager;
    public Module_3_Wiping wipe;
    public FirstAidScript FirstAid;
    public QuizManager quiz;
    private void OnTriggerEnter(Collider other)
    {
        // Check if the collided object has the "Spill" tag (adjust the tag as needed)
        if (other.CompareTag("spill"))
        {
            // Call the function to display the UI panel
            uiManager.SpillOption();
            uiManager.spillObjs();
            uiManager.DontShowObjectPanel();
        }
    }

    public void StartFirstAid()
    {
        wipe.enabled = false;
        FirstAid.enabled = true;
    }public void StartQuiz()
    {
        wipe.enabled = false;
        FirstAid.enabled = false;
        quiz.enabled = true;
    }
}
