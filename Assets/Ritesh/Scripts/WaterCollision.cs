using UnityEngine;
using System.Collections.Generic;
using Utils;

public class WaterCollision : MonoBehaviour
{
    public string fireTag = "fire";
    public float emissionDecreaseRate = 0.1f;

    private ParticleSystem waterParticleSystem;
    private List<ParticleCollisionEvent> collisionEvents;

    private Transform fireTransform; // Reference to the transform of the fire GameObject
    private GameObject smokeGameObject; // Reference to the smoke GameObject

    public GameObject classAPanel;
    public GameObject offpanel;
    public GameObject FireExample;
    public GameObject evacuation;
    public GameObject Lid;
    public AudioSource fireAudio;
    public AudioSource smokeAudio;
    void Start()
    {
        waterParticleSystem = GetComponent<ParticleSystem>();
        collisionEvents = new List<ParticleCollisionEvent>();

        // Find the GameObject with the "fire" tag
        GameObject fireObject = GameObject.FindGameObjectWithTag(fireTag);

        if (fireObject != null)
        {
            // Get the transform of the fire GameObject
            fireTransform = fireObject.transform;

            // Find the smoke GameObject as a child of the fire GameObject by name
            smokeGameObject = fireTransform.Find("Steam old")?.gameObject;

            if (smokeGameObject != null)
            {
                // Ensure the smoke GameObject is inactive at the start
                smokeGameObject.SetActive(false);
                Debug.Log("Smoke GameObject found and set inactive. GameObject Name: " + smokeGameObject.name);
            }
            else
            {
                Debug.LogError("Smoke GameObject not found as a child of the fire GameObject!");
            }

            // Start the fire particle system
            ParticleSystem fireParticleSystem = fireObject.GetComponent<ParticleSystem>();
            if (fireParticleSystem != null)
            {
                fireParticleSystem.Play();
                Debug.Log("Fire Particle System is now playing.");
            }
            else
            {
                Debug.LogError("Fire Particle System not found!");
            }
        }
        else
        {
            Debug.LogError("Fire GameObject not found!");
        }
    }
    public void classA()
    {
        classAPanel.SetActive(true);
    }
    void OnParticleCollision(GameObject other)
    {
        // Check if the colliding object has the "fire" tag
        if (other.CompareTag(fireTag))
        {
            // Access the ParticleSystem component of the fire object
            ParticleSystem fireParticleSystem = other.GetComponent<ParticleSystem>();
           
            // Decrease emission rate
            if (fireParticleSystem != null)
            {
                float deltaTime = Time.deltaTime;
                var emission = fireParticleSystem.emission;
                emission.rateOverTimeMultiplier -= emissionDecreaseRate * deltaTime;
               
                // Ensure emission rate doesn't go below zero
                emission.rateOverTimeMultiplier = Mathf.Max(emission.rateOverTimeMultiplier, 0f);

                if (fireAudio != null)
                {
                    float targetVolume = emission.rateOverTimeMultiplier / 100f; // Adjust this factor as needed

                    fireAudio.volume = Mathf.Lerp(fireAudio.volume, targetVolume, deltaTime);
                }
                // Toggle the activation of the smoke GameObject based on the emission rate
                if (emission.rateOverTimeMultiplier > 0f)
                {
                    if (smokeGameObject != null && !smokeGameObject.activeSelf)
                    {
                        smokeGameObject.SetActive(true);
                        Debug.Log("Smoke GameObject is now active.");
                        smokeGameObject.GetComponent<ParticleSystem>().Play();
                        smokeAudio.Play();
                    }
                }
                else
                {
                    if (smokeGameObject != null && smokeGameObject.activeSelf)
                    {
                        smokeGameObject.SetActive(false);
                        smokeAudio.Stop();
                        smokeGameObject.GetComponent<ParticleSystem>().Stop();
                        Debug.Log("Smoke GameObject is now inactive.");
                    }
                }
                if(emission.rateOverTimeMultiplier <= 0f && other.transform.name == "LargeFlames")
                {
                    classAPanel.SetActive(true);
                    offpanel.SetActive(false);
                    FireExample.SetActive(false);
                   
                    Lid.SetActive(false);
                }

                if (emission.rateOverTimeMultiplier <= 0f && other.transform.name == "clothflames")
                {
                    fireAudio.Stop();
                }
            }
        }
    }
}
