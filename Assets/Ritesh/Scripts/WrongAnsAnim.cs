using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WrongAnsAnim : MonoBehaviour
{
    // Start is called before the first frame update
    private Animator animator;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void playAnim()
    {
        animator = GetComponent<Animator>();
        animator.SetBool("isWrong", true);
    }
}
