using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1 : MonoBehaviour
{
    string StartUp = "Welcome!";
    Rigidbody2D Body = null;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(StartUp);
        Debug.Log(Body);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
