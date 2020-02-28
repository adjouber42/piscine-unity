using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    private float jauge = 0;
    private int score = -15;
    private bool hold;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            jauge+= 0;
            hold = true;
        }
        if (Input.GetKeyUp("space"))
        {
            score += 5;
            print("Score: " + score);
            hold = false;
        }
        if (hold)
        {
            jauge += 0.5f;
        }
    }
}
