using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour
{
    
    
    public Transform playerTransform;

    public Vector3 cameraOffset;

    public float smoothFactor = 0.5f;

    public bool LookAtPlayer = false;

    void Start()
    {
        cameraOffset = transform.position - playerTransform.position;
    }

    void LateUpdate()
    {
        Vector3 newPosition = playerTransform.position + cameraOffset;
        transform.position = Vector3.Slerp(transform.position, newPosition, smoothFactor);

        if (LookAtPlayer)
        {
            transform.LookAt(playerTransform);
        }
    }
}
