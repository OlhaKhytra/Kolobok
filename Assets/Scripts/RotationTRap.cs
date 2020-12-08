using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RotationTRap : MonoBehaviour
{
    public float rotationspeed;
    void Start()
    {
        
    }
    private void FixedUpdate()
    {
        this.transform.Rotate(new Vector3(0, 0, rotationspeed));
    }
   
}
