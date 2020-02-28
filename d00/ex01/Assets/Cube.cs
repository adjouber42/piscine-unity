using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    private float speed;
    // Start is called before the first frame update
    void Start()
    {
        speed = Random.Range(-0.05f, -0.2f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(0, speed / 2, 0));
    }
}
