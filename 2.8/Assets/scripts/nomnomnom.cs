using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nomnomnom : MonoBehaviour
{
    public static int count;
    // Start is called before the first frame update
    void Start()
    {
        count = 0;
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
           Destroy(gameObject);
           count = count + 1;
           Debug.Log(count);
        }
    }
}
