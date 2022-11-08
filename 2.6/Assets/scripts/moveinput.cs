using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveinput : MonoBehaviour
{
    public Animator animator; 
    float HorizontalSpeed = 0.01f;
   // float VerticalSpeed = 0.01f;
    // Start is called before the first frame update
    // Update is called once per frame
   // void start()
  //  {
    //    InvokeRepeating("flip", 2.0f, 1.3f);
 //   }
    void Update()
    {
        float h = HorizontalSpeed * Input.GetAxis("Horizontal");
        animator.SetFloat("Speed", Mathf.Abs(h));
      //  float v = VerticalSpeed * Input.GetAxis("Vertical");
        transform.Translate(h, 0, 0);
        // transform.Translate(0, v, 0);
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
    }
   // void flip()
  //  {


 
  ///  }
}
