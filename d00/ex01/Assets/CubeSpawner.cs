using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeSpawner : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject prefab;
    int i;
    private GameObject tt;

    void Start()
    {
        
    }
    // Update is called once per frame
    void Update()
    {
        i = Random.Range(0, 50);
        if (!tt && i == 10 && prefab)
        {
            tt = (GameObject)GameObject.Instantiate(prefab, transform.position, Quaternion.identity);
        }
        if (tt && tt.transform.position.y < -5)
            Destroy(tt);
        if (tt && Input.GetKeyDown("a") && prefab.name == "A")
        {
            Debug.Log("Precision: " + ((tt.transform.position.y - 5) * -10));
            Destroy(tt);
        }
        if (tt && Input.GetKeyDown("s") && prefab.name == "S")
        {
            Debug.Log("Precision: " + ((tt.transform.position.y - 5) * -10));
            Destroy(tt);
        }
        if (tt && Input.GetKeyDown("d") && prefab.name == "D")
        {
            Debug.Log("Precision: " + ((tt.transform.position.y - 5) * -10));
            Destroy(tt);
        }
    }
}
