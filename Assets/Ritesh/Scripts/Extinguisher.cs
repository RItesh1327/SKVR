using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Extinguisher : MonoBehaviour
{
    public Animator anim;
    public ParticleSystem particle;
    private Transform objectTransform;
    private Vector3 initialLocalPosition;
    private Quaternion initialLocalRotation;

    // Start is called before the first frame update
    void Start()
    {
        //   particle = GetComponent<ParticleSystem>();
        // Get the Transform component
        objectTransform = GetComponent<Transform>();

     ;

        // Store initial local position and rotation
        initialLocalPosition = objectTransform.localPosition;
        initialLocalRotation = objectTransform.localRotation;
     //   Debug.LogError("Position At start" + initialLocalPosition + "Rotation at start"  + initialLocalRotation);
    
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Spray()
    {
        particle.Play();
    }

    public void StopSpray()
    {
        particle.Stop();
        
    }

    public void playAnim()
    {
        anim.SetBool("press", true);
    }
    public void StopAnim()
    {
        anim.SetBool("press", false);
    }
    public void ObjectLetGo()
    {
        Debug.LogError("Moved");
        objectTransform.localPosition = initialLocalPosition;
        objectTransform.localRotation = initialLocalRotation;
        Debug.LogError("Position" + initialLocalPosition + "Rotation" + initialLocalRotation);
    }
}
