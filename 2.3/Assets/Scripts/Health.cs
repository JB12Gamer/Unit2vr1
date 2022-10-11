using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    int Hearts;
    // Start is called before the first frame update
    void Start()
    {
        Hearts = 100;
        
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(Hearts);
        Hearts = Hearts - 1;
    }
}
