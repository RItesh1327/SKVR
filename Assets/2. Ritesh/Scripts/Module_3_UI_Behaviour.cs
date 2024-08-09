using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.SceneManagement;
using System.Collections.Generic;
using UnityEngine.InputSystem;
using System.Collections;
using System.Linq;
using System;

public class Module_3_UI_Behaviour : MonoBehaviour
{
    public GameObject objectToDisplay;
    // Custom attribute to enforce the assignment
    private AudioManager audioManager;
    private ActionBasedContinuousMoveProvider MoveProvider;
    public GameObject MainUI;
    private LocomotionSystem locomotion;
    private bool inZone = true;
    private bool allowMovement = true; // Variable to control movement
    public List<GameObject> panels;
    public List<GameObject> hotObjects;
    public List<GameObject> MissionObjects;
    public Module.missionState MissionState { get; set; }

    public Module.LevelNo level;
    public List<Transform> MissionPos;
    public GameObject objpanel;
    private List<Vector3> initialPositions = new List<Vector3>();
    public bool gameplay = false;
    public bool startGame = false;
    private XRBaseInteractor currentInteractor;

    private DeviceBasedContinuousMoveProvider continuousMoveProvider;
    public Animator ovenAnimator;
    public Animator WrongAnswer;
    // Reference to the camera
    public Camera mainCamera;
    public bool hand = true;
    public GameObject handObj;
    public GameObject mittObj; private Vector3 mittObjInitialPosition;
    public GameObject mittObjOriginal; 
    private GameObject resetPanel;
    private Vector3 panpos;
    private Vector3 traypos;
    private Vector3 fryerpos;
    //  public GameObject fryer;
    // Helper method to find the resetPanel in all scenes
    private bool obj1Pressed = false;
    private bool obj2Pressed = false;
    private bool obj3Pressed = false;

    private bool obj1finished = false;
    private bool obj2finished= false;
    private bool obj3finished = false;
       public AudioClip oneShotClip;
       public AudioClip oneShotClip2;
       public AudioClip oneShotClip3;
       public AudioClip oneShotClip4;
       public AudioClip oneShotClip5;
       public AudioClip oneShotClip6;
    public AudioClip loopClip;
 //   public AudioClip[] sequenceClips;
    void Awake()
    {
        audioManager = GetComponent<AudioManager>();

        if (audioManager == null)
        {
            // AudioManager not found, create and attach it
          
            Debug.Log("AudioManager component not found. Created and attached.");
        
        }
        else
        {
            Debug.Log("AudioManager found in Awake!");
        }

        locomotion = this.gameObject.GetComponent<LocomotionSystem>();
        MoveProvider = this.gameObject.GetComponent<ActionBasedContinuousMoveProvider>();

        locomotion.enabled = false;
        MoveProvider.enabled = false;
    }
    IEnumerator DisplayAndHideObject()
    {
        // Display the object
        objectToDisplay.SetActive(true);

        // Wait for 3 seconds
        yield return new WaitForSeconds(3f);

        // Hide the object after 3 seconds
        objectToDisplay.SetActive(false);
    }
    void Start()
    {
        startGame = false;
        if (audioManager != null)
        {
           
          //  audioManager.PlayOneShot(oneShotClip);
          //   audioManager.PlayLoop(loopClip);
          //  audioManager.PlaySequence(sequenceClips);
            Debug.LogError("AudioManager found in Start!");
        }
        mittObjInitialPosition = mittObj.transform.position;
        panpos = MissionObjects[3].transform.position;
        traypos = MissionObjects[1].transform.position;
        fryerpos = MissionObjects[2].transform.position;
        StopDisplayHotObjects();
        resetPanel = GameObject.Find("Prompt Reset");
        DontDisplayReset();
        if (resetPanel == null)
        {
            Debug.LogError("Prompt Reset not found. Make sure the name is correct.");
        }
        XRBaseInteractor interactor = GetComponent<XRBaseInteractor>();
     
        // Get ContinuousMoveProvider component
        continuousMoveProvider = GetComponent<DeviceBasedContinuousMoveProvider>();

        mainCamera = Camera.main;
        MissionState = Module.missionState.lost;
        level = Module.LevelNo.l1;
        gameplay = false;
        inZone = true;
        if (mainCamera == null)
        {
   //         Debug.LogWarning("MainCamera is null. Please assign it in the inspector.");
        }
        

      
        //audioManager.PlaySequence(sequenceClips);
        foreach (GameObject missionObject in MissionObjects)
        {
            if (missionObject != null)
            {
                initialPositions.Add(missionObject.transform.position);
                Debug.Log(initialPositions + "Initial Positions");
                Debug.Log(initialPositions[0]);
            }
        }

        if (initialPositions.Count == 0)
        {
            Debug.LogWarning("No initial positions stored. Make sure MissionObjects have valid positions.");
            MissionObjects[0].transform.position = initialPositions[0];
        }

       
    }
    public void startmodule()
    {
        locomotion.enabled = true;
        MoveProvider.enabled = true;
        MainUI.SetActive(false);
        panels[0].SetActive(true);
        audioManager.StopAudio();
    }
    // Function to activate all child objects of "Prompt Reset"
    public void DisplayReset()
    {
        panels[5].SetActive(false);
        panels[6].SetActive(false);
        if (resetPanel != null)
        {
            foreach (Transform child in resetPanel.transform)
            {
                child.gameObject.SetActive(true);
            }
        }
        else
        {
            Debug.LogError("Prompt Reset is not found. Cannot activate child objects.");
        }
    }
    public void Obj1Socket()
    {  
        if (!hand)
        {

            audioManager.PlayOneShot(oneShotClip);
            audioManager.StopLoop();
            obj1finished = true;
            resethand();
            MissionState = Module.missionState.lost;
            MissionObjects[3].GetComponent<Module_3_Object_Handling>().enabled = false;
            panels[5].SetActive(false);
            gameplay = false;
            // Find the Stove GameObject in the hotObjects list
            
            MissionObjects[0].SetActive(false);
            MissionObjects[3].SetActive(false);

            panels[2].SetActive(false);
            // Find the Grill_B1 GameObject
            
            if (!(obj1finished && obj2finished && obj3finished))
            {
                StartCoroutine(DisplayAndHideObject());
            }
            DisplayHotObjects();
            Debug.LogError("Level 1 Complete");


            StartCoroutine(socket1());
        }
    }
    
    IEnumerator socket1()
    {
        GameObject pan = GameObject.Find("Pan");
        GameObject grillB1 = GameObject.Find("Grill_B1");
        GameObject stove = hotObjects.Find(obj => obj.name == "Stove");
        if (stove != null)
        {
            // Remove the Stove GameObject from the hotObjects list
            hotObjects.Remove(stove);

            // Destroy the Stove GameObject
            Destroy(stove);
        }
        else
        {
            Debug.LogError("Stove not found in hotObjects list");
        }
        yield return new WaitForSeconds(2);
       
       
        if (pan != null)
        {
            XRGrabInteractable interactable = pan.GetComponent<XRGrabInteractable>();

            if (interactable != null)
            {
                interactable.enabled = false;
            }
            else
            {
                Debug.LogError("XRGrabable not found on Pan");
            }
        }
        else
        {
            Debug.LogError("Pan Not found");
        }
       
        if (grillB1 != null)
        {
            // Disable the XRSimpleInteractable component on Grill_B1
            XRSimpleInteractable interactable = grillB1.GetComponent<XRSimpleInteractable>();

            if (interactable != null)
            {
                interactable.enabled = false;
            }
            else
            {
                Debug.LogError("XRSimpleInteractable not found on Grill_B1");
            }
        }
        else
        {
            Debug.LogError("Grill_B1 not found");
        }
    }
    public void Obj2Socket()
    {
        if (!hand)
        {
            audioManager.PlayOneShot(oneShotClip);
            audioManager.StopLoop();
            //  MissionObjects[2].SetActive(true);
            resethand();
            MissionState = Module.missionState.lost;
            obj2finished = true;
            DisplayHotObjects();
            gameplay = false;
            Debug.LogError("Level 2 Complete"); panels[3].SetActive(false);
            // Find the Stove GameObject in the hotObjects list
            
            panels[6].SetActive(false);
          //  MissionObjects[1].SetActive(false);
            StartCoroutine(socket2());
        }
    } 
    IEnumerator socket2()
    {
        GameObject stove = hotObjects.Find(obj => obj.name == "Oven");
        if (stove != null)
        {
            // Remove the Stove GameObject from the hotObjects list
            hotObjects.Remove(stove);

            // Destroy the Stove GameObject
            Destroy(stove);
        }
        else
        {
            Debug.LogError("Stove not found in hotObjects list");
        }
        yield return new WaitForSeconds(2);
       

        // Find the Grill_B1 GameObject
        GameObject grillB1 = GameObject.Find("Oven stuff");

        if (grillB1 != null)
        {
            // Disable the XRSimpleInteractable component on Grill_B1
            XRSimpleInteractable interactable = grillB1.GetComponent<XRSimpleInteractable>();

            if (interactable != null)
            {
                interactable.enabled = false;
            }
            else
            {
                Debug.LogError("XRSimpleInteractable not found on Grill_B1");
            }
        }
        else
        {
            Debug.LogError("Grill_B1 not found");
        }
        GameObject pan = GameObject.Find("tray");
        if (pan != null)
        {
            XRGrabInteractable interactable = pan.GetComponent<XRGrabInteractable>();

            if (interactable != null)
            {
                interactable.enabled = false;
            }
            else
            {
                Debug.LogError("XRGrabable not found on Pan");
            }
        }
        else
        {
            Debug.LogError("Pan Not found");
        }
        if (!(obj1finished && obj2finished && obj3finished))
        {
            StartCoroutine(DisplayAndHideObject());
        }
    }
    public void Obj3Socket()
    {
        audioManager.PlayOneShot(oneShotClip);
        audioManager.StopLoop();
        // MissionObjects[2].SetActive(true);
        resethand();
        MissionState = Module.missionState.lost;
        DisplayHotObjects();
        gameplay = false;
        Debug.LogError("Level 3 Complete"); panels[4].SetActive(false);
        // Find the Stove GameObject in the hotObjects list
        panels[7].SetActive(false);
        obj3finished = true;

        if (!(obj1finished && obj2finished && obj3finished))
        {
            StartCoroutine(DisplayAndHideObject());
        }
       
        StartCoroutine(socket3());
    }
    IEnumerator socket3()
    {
        GameObject stove = hotObjects.Find(obj => obj.name == "Fryer");

        if (stove != null)
        {
            // Remove the Stove GameObject from the hotObjects list
            hotObjects.Remove(stove);

            // Destroy the Stove GameObject
            Destroy(stove);
        }
        else
        {
            Debug.LogError("Stove not found in hotObjects list");
        }
        yield return new WaitForSeconds(2);
        

        // Find the Grill_B1 GameObject
        GameObject grillB1 = GameObject.Find("Fryer");
       
        if (grillB1 != null)
        {
            // Disable the XRSimpleInteractable component on Grill_B1
            XRSimpleInteractable interactable = grillB1.GetComponent<XRSimpleInteractable>();

            if (interactable != null)
            {
                interactable.enabled = false;
            }
            else
            {
                Debug.LogError("XRSimpleInteractable not found on Grill_B1");
            }
        }
        else
        {
            Debug.LogError("Grill_B1 not found");
        }
        GameObject pan = GameObject.Find("FryerPan");
        if (pan != null)
        {
            XRGrabInteractable interactable = pan.GetComponent<XRGrabInteractable>();

            if (interactable != null)
            {
                interactable.enabled = false;
            }
            else
            {
                Debug.LogError("XRGrabable not found on Pan");
            }
        }
        else
        {
            Debug.LogError("Pan Not found");
        }
    }
    public void resethand()
    {
        handObj.SetActive(true);
        mittObj.transform.SetParent(null);
        mittObj.transform.position = mittObjInitialPosition;
        mittObjOriginal.SetActive(false);
        mittObj.SetActive(false);
    }

    // Function to deactivate all child objects of "Prompt Reset"
    public void DontDisplayReset()
    {
        if (resetPanel != null)
        {
            foreach (Transform child in resetPanel.transform)
            {
                child.gameObject.SetActive(false);
            }
        }
        else
        {
            Debug.LogError("Prompt Reset is not found. Cannot deactivate child objects.");
        }
    }
    public void DisplayHotObjects()
    {
        startGame = true;
        if (hotObjects.Count < 1)
        {
            hotObjects[0].SetActive(true);
        }
        else
        {
            foreach (GameObject obj in hotObjects)
            {
                obj.SetActive(true);
            }
        }
    }

    public void StopDisplayHotObjects()
    {
        foreach (GameObject obj in hotObjects)
        {
            obj.SetActive(false);
            Debug.Log("Stopped Displaying");
        }
    }

    private void DisplayPanelWithDelay()
    {
        panels[1].SetActive(true);
        objpanel.SetActive(false);

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Obj"))
        {
        //    Debug.Log("first collision");
            DisplayPanelWithDelay();
        }
    }


    public void Obj1()
    {
        if (startGame)
        {
           

            audioManager.PlayLoop(oneShotClip4);
            Debug.LogError(MissionState);
            Debug.LogError(gameplay);
            if (MissionState == Module.missionState.lost && gameplay == false)
            {
                GameObject pan = GameObject.Find("Pan");
                GameObject grillB1 = GameObject.Find("Grill_B1");

                if (pan != null)
                {
                    XRGrabInteractable interactable = pan.GetComponent<XRGrabInteractable>();

                    if (interactable != null)
                    {
                        interactable.enabled = true;
                    }
                    else
                    {
                        Debug.LogError("XRGrabable not found on Pan");
                    }
                }
                else
                {
                    Debug.LogError("Pan Not found");
                }

                if (grillB1 != null)
                {
                    // Disable the XRSimpleInteractable component on Grill_B1
                    XRSimpleInteractable interactable = grillB1.GetComponent<XRSimpleInteractable>();

                    if (interactable != null)
                    {
                        interactable.enabled = true;
                    }
                    else
                    {
                        Debug.LogError("XRSimpleInteractable not found on Grill_B1");
                    }
                }
                else
                {
                    Debug.LogError("Grill_B1 not found");
                }
                DontDisplayReset();
                StopDisplayHotObjects();

                obj1Pressed = true;
                obj2Pressed = false;
                obj3Pressed = false;
                //  MissionObjects[1].SetActive(false);
                Debug.Log("Mission 1 started!!!");

                //   if (gameplay && MissionObjects != null && MissionObjects.Count > 0 && MissionObjects[0] != null && inZone == true)
                //  {
                // Disable movement during Obj1


                gameplay = true;
                mittObj.SetActive(true);
                MissionObjects[0].SetActive(true);
                MissionObjects[3].transform.position = panpos;
                Debug.Log("Mission 1 started!");
                panels[2].SetActive(true);

                level = Module.LevelNo.l1;
                startGame = false;
            }
        }
    //    }
    //    else
    //    {
         //   Debug.LogError("MissionObjects is not assigned or contains null elements.");
    //    }
    }
    public void Obj2()
    {
        if (startGame)
        {
            if (MissionState == Module.missionState.lost && gameplay != true)
            {
                GameObject grillB1 = GameObject.Find("Oven stuff");

                if (grillB1 != null)
                {
                    // Disable the XRSimpleInteractable component on Grill_B1
                    XRSimpleInteractable interactable = grillB1.GetComponent<XRSimpleInteractable>();

                    if (interactable != null)
                    {
                        interactable.enabled = true;
                    }
                    else
                    {
                        Debug.LogError("XRSimpleInteractable not found on Grill_B1");
                    }
                }
                else
                {
                    Debug.LogError("Grill_B1 not found");
                }
                GameObject pan = GameObject.Find("tray");
                if (pan != null)
                {
                    XRGrabInteractable interactable = pan.GetComponent<XRGrabInteractable>();

                    if (interactable != null)
                    {
                        interactable.enabled = true;
                    }
                    else
                    {
                        Debug.LogError("XRGrabable not found on Pan");
                    }
                }
                else
                {
                    Debug.LogError("Pan Not found");
                }
              
                MissionObjects[1].SetActive(true);
                audioManager.PlayOneShot(oneShotClip6);
                obj1Pressed = false;
                obj2Pressed = true;
                obj3Pressed = false;
                hand = true;
                mittObj.SetActive(true);
                // Toggle the boolean value
                DontDisplayReset();
                StopDisplayHotObjects();
                MissionObjects[1].transform.position = traypos;
                panels[3].SetActive(true);
                MissionObjects[1].GetComponent<Module_3_Object_Handling>().enabled = true;
                ovenAnimator.SetBool("open", !ovenAnimator.GetBool("open"));
                Debug.Log("Mission 2 started!!!");
                level = Module.LevelNo.l2; gameplay = true;
                startGame = false;
            }
        }
        else
        {
            //   ovenAnimator.SetBool("open", !ovenAnimator.GetBool("open"));
        }
        
    }
    public void Obj3()
    {
        if (startGame)
        {
            if (MissionState == Module.missionState.lost && gameplay != true)
            {
                GameObject grillB1 = GameObject.Find("Fryer");
               
                if (grillB1 != null)
                {
                    // Disable the XRSimpleInteractable component on Grill_B1
                    XRSimpleInteractable interactable = grillB1.GetComponent<XRSimpleInteractable>();

                    if (interactable != null)
                    {
                        interactable.enabled = true;
                    }
                    else
                    {
                        Debug.LogError("XRSimpleInteractable not found on Grill_B1");
                    }
                }
                else
                {
                    Debug.LogError("Grill_B1 not found");
                }
                GameObject pan = GameObject.Find("FryerPan");
                if (pan != null)
                {
                    XRGrabInteractable interactable = pan.GetComponent<XRGrabInteractable>();

                    if (interactable != null)
                    {
                        interactable.enabled = true;
                    }
                    else
                    {
                        Debug.LogError("XRGrabable not found on Pan");
                    }
                }
                else
                {
                    Debug.LogError("Pan Not found");
                }
                audioManager.PlayLoop(oneShotClip5);
                MissionObjects[2].SetActive(true);
                obj1Pressed = false;
                obj2Pressed = false;
                obj3Pressed = true;
                panels[4].SetActive(true);
                hand = true;
                // Toggle the boolean value
                DontDisplayReset();
                mittObj.SetActive(true);
                StopDisplayHotObjects();
                MissionObjects[2].transform.position = fryerpos;
                Debug.Log("Mission 3 started!!!");

                level = Module.LevelNo.l3; gameplay = true;
                startGame = false;
            }
        }
    }

    public void replayMission()
    {
        Debug.Log("Trying to Restarting" + MissionState);
        Debug.Log("Trying to Restarting" + level);
        startGame = true;
        if (obj1Pressed)
        {
            resethand();
            Debug.Log("Restarting" + MissionState);
            Debug.Log("Restarting" + level);
            Obj1();
        }
        else if (obj2Pressed)
        {
            resethand();
            Debug.Log("Restarting" + MissionState);
            Debug.Log("Restarting" + level);
            Obj2();
        }
        else if (obj3Pressed)
        {
            Debug.Log("Restarting" + MissionState);
            Debug.Log("Restarting" + level);
            Obj3();
        }
    }

    public void sceneChange()
    {
        SceneManager.LoadScene("Spills");
    }
    // Update is called once per frame
    void Update()
    {

        if (obj1finished && obj2finished && obj3finished)
        {
            panels[8].SetActive(true);
        }
        // Disable ContinuousMoveProvider if movement is not allowed
        if (continuousMoveProvider != null)
        {
            continuousMoveProvider.enabled = allowMovement;
            Debug.Log("Movement is allowed : "+allowMovement);
        }
        else
        {
            Debug.Log("Movement is not allowed : " + allowMovement);
        }
        Debug.Log("Ui Behaviour" + MissionState);
        Debug.Log("MissionObjects count: " + MissionObjects.Count);
        Debug.Log("initialPositions count: " + initialPositions.Count);
    }

 
   

  
}
