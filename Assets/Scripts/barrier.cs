using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class barrier : MonoBehaviour
{
    public float speed;
    public Transform _transformObj;
    private Vector3 direction;

    private void Start()
    {
        _transformObj = GetComponent<Transform>();
        direction = Vector3.forward;
    }

     private void Update()
    {
        _transformObj.Translate(direction * speed * Time.deltaTime);

        if(_transformObj.position.z > 3)
        {
            direction = -Vector3.forward;
        }

        if (_transformObj.position.z > 3)
        {
            direction = Vector3.forward;
        }
    }

}
