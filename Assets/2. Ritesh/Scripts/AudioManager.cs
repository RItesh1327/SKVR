using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class AudioManager : MonoBehaviour
{
    public TMP_Text[] textObjects;
    public Button stopButton;

    public AudioClip audioClip1; // Assign AudioClip for Button 1 in the Unity Editor
    public AudioClip audioClip2; // Assign AudioClip for Button 2 in the Unity Editor
    public AudioClip audioClip3; // Assign AudioClip for Button 3 in the Unity Editor

    private AudioSource audioSource;
    private Coroutine sequenceCoroutine;
    private bool stopAudioRequested = false;

    void Awake()
    {
        audioSource = GetComponent<AudioSource>();
        if (audioSource == null)
        {
            audioSource = gameObject.AddComponent<AudioSource>();
        }

        stopButton.onClick.AddListener(StopAudio);
    }
    public void Start()
    {
        PlayAudio1();
    }
    // Function for Button 1
    public void PlayAudio1()
    {
        PlayOneShot(audioClip1);
    }

    // Function for Button 2
    public void PlayAudio2()
    {
        PlayOneShot(audioClip2);
    }

    // Function for Button 3
    public void PlayAudio3()
    {
        PlayOneShot(audioClip3);
    }

    // Function to stop audio for Button 1
    public void StopAudio1()
    {
        StopLoop();
        StopAudio();
    }

    // Function to stop audio for Button 2
    public void StopAudio2()
    {
        StopLoop();
        StopAudio();
    }

    // Function to stop audio for Button 3
    public void StopAudio3()
    {
        StopLoop();
        StopAudio();
    }

    public void PlayOneShot(AudioClip clip, float volume = 1.0f, float pitch = 1.0f)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.enabled = true;
            audioSource.PlayOneShot(clip, volume);
            audioSource.pitch = pitch;
        }
        else
        {
            Debug.LogError("AudioSource or AudioClip is null!");
        }
    }

    public void StopLoop()
    {
        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
            audioSource.loop = false;
        }
    }

    public void StopAudio()
    {
        stopAudioRequested = true;

        if (sequenceCoroutine != null)
        {
            StopCoroutine(sequenceCoroutine);
            sequenceCoroutine = null;
        }

        if (audioSource != null && audioSource.isPlaying)
        {
            audioSource.Stop();
            audioSource.enabled = false;
        }

        Destroy(audioSource);
        audioSource = gameObject.AddComponent<AudioSource>();

        stopAudioRequested = false;
    }

    public void PlayLoop(AudioClip clip, float volume = 1.0f, float pitch = 1.0f)
    {
        if (audioSource != null && clip != null)
        {
            audioSource.enabled = true;
            audioSource.clip = clip;
            audioSource.volume = volume;
            audioSource.pitch = pitch;
            audioSource.loop = true;
            audioSource.Play();
            Debug.Log("Playing Loop on AudioManager: " + gameObject.name);
            Debug.Log("Using AudioSource: " + audioSource.name);
        }
        else
        {
            Debug.LogError("AudioSource or AudioClip is null!");
        }
    }
}
