using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    GameObject      current;
    private GameObject   red;
    private GameObject   blue;
    private GameObject   yellow;
    
    void Start()
    {
        red = GameObject.Find("red");
        blue = GameObject.Find("blue");
        yellow = GameObject.Find("yellow");
        current = red;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
            current = red;
        if (Input.GetKeyDown(KeyCode.Alpha2))
            current = blue;
        if (Input.GetKeyDown(KeyCode.Alpha3))
            current = yellow;
        Transform t;
		t = current.GetComponent<Transform> (); 
		transform.localPosition = new Vector3 (t.position.x, t.position.y, -8.0f);
    }
}
