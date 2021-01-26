using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour
{
    public float speed;
   
    public int jumpForce;
    public bool isGround;
   

    private Rigidbody rb;
    

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * speed);

        Jump();
    }

    public void Jump()
    {
        Ray ray = new Ray(gameObject.transform.position, Vector3.down);
        RaycastHit rh;
        if (Physics.Raycast(ray, out rh, 0.7f))
        {
            isGround = true;
        }
        else
        {
            isGround = false;
        }
        if (Input.GetKeyDown(KeyCode.Space) && isGround)
        {
            rb.AddForce(Vector3.up * jumpForce);
        }
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pick up"))
        {
            other.gameObject.SetActive (false);
        }
    }
    
}
