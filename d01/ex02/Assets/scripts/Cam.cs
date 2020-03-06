using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cam : MonoBehaviour
{
    GameObject      current;
    public GameObject   red;
    public GameObject   blue;
    public GameObject   yellow;
    // Start is called before the first frame update
    void Start()
    {
        current = red;
    }

    // Update is called once per frame
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
