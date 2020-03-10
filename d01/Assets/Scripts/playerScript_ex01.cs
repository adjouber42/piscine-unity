using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerScript_ex01 : MonoBehaviour
{
    private bool active;
    private bool jumping;
    public bool win;
    private int speed;
    private float jump;

    void Start()
    {
        speed = 2;
        jump = 250f;
        jumping = false;
        if (gameObject.name == "red")
            active = true;
        else
            active = false;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            if (gameObject.name == "red")
            {
                active = true;
                speed = 2;
                jump = 250f;
            }
            else
                active = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            if (gameObject.name == "blue")
            {
                active = true;
                speed = 1;
                jump = 150f;
            }
            else
                active = false;
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            if (gameObject.name == "yellow")
            {
                active = true;
                speed = 3;
                jump = 350f;
            }
            else
                active = false;
        }
        if (!active)
        {
            GetComponent<Rigidbody2D>().mass = 1f;
            GetComponent<Rigidbody2D>().velocity = (new Vector2(0, GetComponent<Rigidbody2D>().velocity.y));
        }
        else
        {
            GetComponent<Rigidbody2D>().mass = 1f;
            if (Input.GetKey("left"))
                GetComponent<Rigidbody2D>().velocity = (new Vector2(-speed, GetComponent<Rigidbody2D>().velocity.y));
            else if (Input.GetKey("right"))
                GetComponent<Rigidbody2D>().velocity = (new Vector2(speed, GetComponent<Rigidbody2D>().velocity.y));
            else
                GetComponent<Rigidbody2D>().velocity = (new Vector2(0, GetComponent<Rigidbody2D>().velocity.y));            
            if (Input.GetKey("space") && !jumping)
            {
                GetComponent<Rigidbody2D>().AddForce(new Vector2(0, jump));
                jumping = true;
            }
        }
    }

    void    OnCollisionEnter2D(Collision2D coll)
    {
        if(coll.contacts.Length > 0)
        {
            ContactPoint2D contact = coll.contacts[0];
            if(Vector3.Dot(contact.normal, Vector3.up) > 0.5)
            {
                jumping = false;
            }
            if (coll.gameObject.tag == "move")
            {
                this.transform.parent = coll.transform;
            }
        }
    }

    void    OnCollisionExit2D(Collision2D coll)
    {
        if (coll.gameObject.tag == "move")
        {
            this.transform.parent = null;
        }
    }

    void   OnTriggerEnter2D(Collider2D col)
    {
        if (col.tag == gameObject.name)
            win = true;
    }
}
