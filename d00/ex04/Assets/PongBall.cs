using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PongBall : MonoBehaviour
{
    public float    x;
    public float    y;
    public int    scoreP1 = 0;
    public int    scoreP2 = 0;
    // Start is called before the first frame update
    void Start()
    {
        x = 0.02f;
        if (Random.Range(-1.0f, 1.0f) < 0.0f)
            x = x * -1;
        y = Random.Range(-0.03f, 0.03f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector3(x, y, 0.0f));
        if (transform.position.y > 3.5f || transform.position.y < -3.5f)
            y = -1 * y;
        if (transform.position.x < -6.5f)
        {
            scoreP1++;
            Debug.Log("Player 1: " + scoreP1 + " | Player 2: " + scoreP2);
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            x = 0.02f;
            if (Random.Range(-1.0f, 1.0f) < 0.0f)
                x = x * -1;
            y = Random.Range(-0.03f, 0.03f);
        }
        if (transform.position.x > 6.5f)
        {
            scoreP2++;
            Debug.Log("Player 1: " + scoreP1 + " | Player 2: " + scoreP2);
            transform.position = new Vector3(0.0f, 0.0f, 0.0f);
            x = 0.02f;
            if (Random.Range(-1.0f, 1.0f) < 0.0f)
                x = x * -1;
            y = Random.Range(-0.03f, 0.03f);
        }

    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        if (coll.gameObject.tag == "Player1" || coll.gameObject.tag == "Player2")
            x = -1 * x;
    }
}
