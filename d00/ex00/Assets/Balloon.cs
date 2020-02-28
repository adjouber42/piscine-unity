using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class balloon : MonoBehaviour
{   
     // Start is called before the first frame update
    void Start()
    {
        
    }
    public int jauge = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("space"))
        {
            if (jauge < 5)
            {
                transform.localScale = new Vector3 (transform.localScale[0] + 0.2f, transform.localScale[1] + 0.2f, transform.localScale[2] + 0.2f);
                jauge++;
            }
        }
        if (Mathf.RoundToInt(10.0f * Time.realtimeSinceStartup % 8) == 0)
        {
            if (jauge > 0)
                jauge--;
        }
        if (Mathf.RoundToInt(10.0f * Time.realtimeSinceStartup % 5) == 0)
            transform.localScale = new Vector3 (transform.localScale[0] - 0.05f, transform.localScale[1] - 0.05f, transform.localScale[2] - 0.05f);
        if (transform.localScale[0] > 3.0f || transform.localScale[0] <= 0.0f)
        {
            Destroy(gameObject);
            print("Balloon life time: " + Mathf.RoundToInt(Time.realtimeSinceStartup) + "s");
        }

    }
}
