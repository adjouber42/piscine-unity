using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinCondition : MonoBehaviour
{
    private GameObject   red;
    private GameObject   blue;
    private GameObject   yellow;
    private Scene currentLevel;

    void Start()
    {
        currentLevel = SceneManager.GetActiveScene();
        red = GameObject.Find("red");
        blue = GameObject.Find("blue");
        yellow = GameObject.Find("yellow");
    }
    
    void Update()
    {
        if (red.GetComponent<playerScript_ex01>().win && blue.GetComponent<playerScript_ex01>().win && yellow.GetComponent<playerScript_ex01>().win)
        {
            SceneManager.LoadScene(currentLevel.buildIndex + 1);
        }
    }
}
