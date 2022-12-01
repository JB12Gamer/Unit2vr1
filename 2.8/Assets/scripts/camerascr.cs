using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class camerascr : MonoBehaviour
{
    Vector2 moveUp;
    Vector2 stop;
    Transform camera1;
    public static bool player;
    // Start is called before the first frame update
    void Start()
    {
        moveUp = new Vector2(0.0f, 1.0f);
        camera1 = gameObject.transform;
        stop = new Vector2(0.0f, 0.0f);
        player = true;
    }

    // Update is called once per frame
    void Update()
    {
        if (player == true)
        { 
            camera1.Translate(moveUp * Time.deltaTime);
        }
        if (movement.health < 1)
        {
            Destroy(GameObject.FindWithTag("Player"));
            camera1.Translate(stop);
            player = false;
        }
    }

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {   
            if (movement.health <= 1)
            {
                Destroy(GameObject.FindWithTag("Player"));
                camera1.Translate(stop);
                player = false;
            }
            
        }
    }
}
