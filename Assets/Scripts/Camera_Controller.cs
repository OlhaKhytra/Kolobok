using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Controller : MonoBehaviour {
    public Transform playerTransform;


    public float smoothFactor = 0.9f;

    public bool LookAtPlayer = false;


    void LateUpdate() {
        transform.position = Vector3.Slerp(transform.position, playerTransform.position, smoothFactor);

        transform.rotation = Quaternion.Slerp(transform.rotation, Quaternion.LookRotation(Vector3.ProjectOnPlane(playerTransform.GetComponent<Rigidbody>().velocity, Vector3.up), Vector3.up), smoothFactor);
        ////Vector3 newPosition = playerTransform.position + cameraOffset;
        //

        if(LookAtPlayer) {
            transform.LookAt(playerTransform);
        }
    }
}
