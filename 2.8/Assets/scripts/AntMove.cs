using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AntMove : MonoBehaviour
{

    Rigidbody2D a_Rigidbody;
    float HorizontalSpeed = 0.01f;
    public float h;
    public Vector2 scaleChange1;
    public Vector2 scaleChange = new Vector2(-4.3f, 4.3f);
    // Start is called before the first frame update
    void Start()
    {
        a_Rigidbody = GetComponent<Rigidbody2D>();
        h = HorizontalSpeed * 200.0f;
        Vector2 scaleChange = new Vector2(-4.3f, 4.3f);
        transform.localScale = scaleChange;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(h * Time.deltaTime, 0, 0);
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "pathing")
        {
            Debug.Log("hit");
            h = HorizontalSpeed * -200.0f;
            transform.Translate(h * Time.deltaTime, 0, 0);
            scaleChange1 = scaleChange * new Vector2(-1, 1);
            transform.localScale = scaleChange1;
        }

    }
}
