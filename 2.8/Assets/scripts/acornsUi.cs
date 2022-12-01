using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using System.Collections;

public class acornsUi : MonoBehaviour
{
    public string Accorns;
    public string heallth;
    public int fontss = 90;
    public int font2 = 20;
    //public Text text;
    // public float countn
    // Start is called before the first frame update
    void Start()
    {
        //countn = 0;

    }

    // Update is called once per frame
    void Update()
    {
        Accorns = "ACORNS: " + nomnomnom.count;
        heallth = "HEALTH: " + movement.health;
        //countn += nomnomnom.count;
        //text.text = Accorns;
    }
    void OnGUI()
    {
        GUIStyle healthh = new GUIStyle(GUI.skin.box);
        healthh.normal.textColor = Color.white;
        if (movement.health < 2)
        {
            healthh.normal.textColor = Color.red;
        }
        healthh.alignment = TextAnchor.MiddleCenter;
        healthh.fontSize = font2;
        GUIStyle acorrns = new GUIStyle(GUI.skin.box);
        acorrns.normal.textColor = Color.white;
        acorrns.alignment = TextAnchor.MiddleCenter;
        acorrns.fontSize = font2;
        GUI.Box(new Rect(1000, 555, 120, 25), Accorns, acorrns);
        GUI.Box(new Rect(1000, 520, 120, 25), heallth, healthh);
        if (movement.health < 1 || camerascr.player == false)
        {
            GUIStyle fonts = new GUIStyle(GUI.skin.box);
            fonts.fontSize = fontss;
            //fonts.font = 
            fonts.alignment = TextAnchor.MiddleCenter;
            GUI.color = Color.red;
            GUI.backgroundColor = Color.black;
            GUI.Box(new Rect(275, 160, 600, 300), "Game Over", fonts);
            StartCoroutine(Example());



        }
    }
    IEnumerator Example()
    {
        if (movement.health < 1 || camerascr.player == false)
        {
            Debug.Log("PANIC");
            yield return new WaitForSeconds(3);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
