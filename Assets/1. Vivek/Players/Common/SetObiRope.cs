using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetObiRope : MonoBehaviour
{
    public Vector3 pos;
    // Start is called before the first frame update
    void Start()
    {
        transform.localPosition = pos;
    }

}
