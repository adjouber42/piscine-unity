using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openDoor : MonoBehaviour
{
    private GameObject door;

    void Start()
    {
        door = this.gameObject.transform.GetChild(0).gameObject;
    }

    void OnTriggerEnter2D(Collider2D coll)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y - 0.03f, transform.position.z);
        if (transform.tag == "white" || transform.tag == coll.gameObject.name)
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y + 0.63f, door.transform.position.z);
    }

    void OnTriggerExit2D(Collider2D coll)
    {
        transform.position = new Vector3(transform.position.x, transform.position.y + 0.03f, transform.position.z);
        if (transform.tag == "white" || transform.tag == coll.gameObject.name)
            door.transform.position = new Vector3(door.transform.position.x, door.transform.position.y - 0.63f, door.transform.position.z);
    }
}
