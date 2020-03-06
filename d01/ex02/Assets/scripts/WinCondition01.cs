using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WinCondition01 : MonoBehaviour
{
    public GameObject   red;
    public GameObject   blue;
    public GameObject   yellow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (red.GetComponent<playerScript_ex01>().win && blue.GetComponent<playerScript_ex01>().win && yellow.GetComponent<playerScript_ex01>().win)
            Application.LoadLevel("ex02");
    }
}
