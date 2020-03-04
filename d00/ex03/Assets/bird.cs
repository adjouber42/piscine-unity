using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bird : MonoBehaviour
{
    private bool play = true;
    private int i = 0;
    private float   time = 0;
    public int  score = -5;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (play)
        {
            time += Time.deltaTime;
            if (Input.GetKeyDown("space"))
                i = 10;
            if (i != 0)
            {
                transform.Translate(new Vector3(0.0f, 0.1f, 0.0f));
                i--;
            }
            else
                transform.Translate(new Vector3(0.0f, -0.01f, 0.0f));
        }
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Not Ok" && play == true)
        {
            Debug.Log ("Score: " + score);
            Debug.Log ("Time: " + Mathf.RoundToInt(time) + "s");
            play = false;
        }
        else if (coll.gameObject.tag == "Ok" && play == true)
            score += 5;
    }
}
