using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    Vector2 xMove;
    Transform player;
    // Start is called before the first frame update
    void Start()
    {
        player = gameObject.transform;
        xMove = new Vector2(1.0f, 0.0f);
 
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Time.deltaTime, 0.0f, 0.0f);
    }
}
