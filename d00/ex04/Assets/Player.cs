using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.tag == "Player1")
        {
            if (Input.GetKey("w") && transform.position.y < 2.9)
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.02f, transform.position.z);
            if (Input.GetKey("s") && transform.position.y > -2.9)
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);
        }
        if (gameObject.tag == "Player2")
        {
            if (Input.GetKey("up") && transform.position.y < 2.9)
                transform.position = new Vector3(transform.position.x, transform.position.y + 0.02f, transform.position.z);
            if (Input.GetKey("down") && transform.position.y > -2.9)
                transform.position = new Vector3(transform.position.x, transform.position.y - 0.02f, transform.position.z);
        }
    }
}
