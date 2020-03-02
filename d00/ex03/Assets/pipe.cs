using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float speed;
    private GameObject[] pipes;
    // Start is called before the first frame update
    void Start()
    {
        speed = -0.02f;
        pipes = GameObject.FindGameObjectsWithTag("pipe");
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed, 0.0f, 0.0f));
        foreach (GameObject pipe in pipes)
        {
            if (pipe.transform.position.x < -7.0f)
            {
                speed -= 0.01f;
            }
        }
        if (transform.position.x < -7.0f)
        {
            transform.position = new Vector3(7.0f, transform.position.y, transform.position.z);
        }
    }
}
