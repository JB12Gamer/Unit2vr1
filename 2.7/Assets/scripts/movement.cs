using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movement : MonoBehaviour
{
    public Animator animator;
    float HorizontalSpeed = 0.01f;
    public float m_Thrust = 300.0f;
    Rigidbody2D m_Rigidbody;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        float h = HorizontalSpeed * Input.GetAxis("Horizontal") * 3;
        animator.SetFloat("Speed", Mathf.Abs(h));
        transform.Translate(h, 0, 0);
        if (Input.GetKey("left"))
        {

            Vector2 scaleChange = new Vector2(-5, 5);
            transform.localScale = scaleChange;
        }
        else if (Input.GetKey("right"))
        {
            Vector2 scaleChange = new Vector2(5, 5);
            transform.localScale = scaleChange;
        }
        if (m_Rigidbody.velocity.y != 0)
        {
            animator.SetBool("InAir", true);
        }
        else
        {
            animator.SetBool("InAir", false);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                m_Rigidbody.AddForce(transform.up * m_Thrust);
            }
        }

    }

 
   
}
