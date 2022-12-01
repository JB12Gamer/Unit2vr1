using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class movement : MonoBehaviour
{
    public Animator animator;
    public float HorizontalSpeed = 0.01f;
    public float m_Thrust = 700.0f;
    public  Rigidbody2D m_Rigidbody;
    public float h;
    public static int  health;
    void Start()
    {
        m_Rigidbody = GetComponent<Rigidbody2D>();
        health = 3;
    }
    void Update()
    {
        if (m_Rigidbody.velocity.y > 0.001 || m_Rigidbody.velocity.y < -0.001)
        {
            animator.SetBool("InAir", true);
            animator.SetBool("Crouch", false);
            animator.SetBool("OnGround", false);
        }
        else
        {
            animator.SetBool("InAir", false);
            animator.SetBool("OnGround", true);
            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                m_Rigidbody.AddForce(transform.up * m_Thrust);
            }
        }
        if (Input.GetKey(KeyCode.DownArrow) & animator.GetBool("OnGround"))
        {
            animator.SetBool("Crouch", true);
            h = HorizontalSpeed * Input.GetAxis("Horizontal") * 300.0f;
            animator.SetFloat("Speed", Mathf.Abs(h));
            transform.Translate(h * Time.deltaTime, 0, 0);
        }
        else
        {
            animator.SetBool("Crouch", false);
            h = HorizontalSpeed * Input.GetAxis("Horizontal") * 500.0f;
            animator.SetFloat("Speed", Mathf.Abs(h));
            transform.Translate(h * Time.deltaTime, 0, 0);
        }

        if (Input.GetKey("left"))
        {

            Vector2 scaleChange = new Vector2(-4.3f, 4.3f);
            transform.localScale = scaleChange;
        }
        else if (Input.GetKey("right"))
        {
            Vector2 scaleChange = new Vector2(4.3f, 4.3f);
            transform.localScale = scaleChange;
        }




    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Acorn")
        {
            Debug.Log("NOM NOM NOM");

        }
        if (collision.gameObject.tag == "MainCamera")
        {
            if (health > 1)
            {
                animator.SetBool("InAir", false);
                animator.SetBool("OnGround", true);
                m_Rigidbody.AddForce(transform.up * m_Thrust * 2.0f);
                animator.SetBool("InAir", true);
                animator.SetBool("OnGround", false);
                health -= 1;
            }

        }
        if (collision.gameObject.tag == "Finish")
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }

    }
    public void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            health -= 1;
            Debug.Log("Ouch");
        }
    }
}
