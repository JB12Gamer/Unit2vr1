using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class juump : MonoBehaviour
{
    private bool isGrounded;
    float VerticalSpeed = 0.1f;
    // private Collider2D collide;
    //void start()
    //{
    //collide = GetComponent<Collider>();
    //}

    void Update()
    {
        if (Input.GetKey("up"))
        {
            if (isGrounded)
            {
                float v = VerticalSpeed + Input.GetAxis("Vertical");
                transform.Translate(0, v, 0);
            }
        }
    }

    void OnCollisionEnter(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = true;
        }
    }

    void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "ground")
        {
            isGrounded = false;
        }
    }
}