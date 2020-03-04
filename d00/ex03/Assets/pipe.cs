using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    public float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = -0.02f;
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(speed, 0.0f, 0.0f));
        if (transform.position.x < -7.0f)
        {
            transform.position = new Vector3(7.0f, transform.position.y, transform.position.z);
            speed -= 0.005f;
        }
    }
}
