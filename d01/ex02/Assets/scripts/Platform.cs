using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform : MonoBehaviour
{
    public GameObject   red;
    public GameObject   blue;
    public GameObject   yellow;
    public GameObject   platRed;
    public GameObject   platBlue;
    public GameObject   platYellow;
    // Start is called before the first frame update
    void Start()
    {
        Physics2D.IgnoreCollision(red.GetComponent<Collider2D>(), platBlue.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(red.GetComponent<Collider2D>(), platYellow.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(blue.GetComponent<Collider2D>(), platYellow.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(blue.GetComponent<Collider2D>(), platRed.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(yellow.GetComponent<Collider2D>(), platRed.GetComponent<Collider2D>());
        Physics2D.IgnoreCollision(yellow.GetComponent<Collider2D>(), platBlue.GetComponent<Collider2D>());
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
