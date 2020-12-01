using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotation : MonoBehaviour
{
    public float rotationspeed;
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0,0, rotationspeed));
    }
}
