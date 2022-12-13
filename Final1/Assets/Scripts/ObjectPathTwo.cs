using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPathTwo : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("I'm Working");
    }
    void Update()
    {
        if (EnemySlime.slime == 0)
        {
            Debug.Log("SlimeDead");
            Destroy(gameObject);
        }
    }
}
