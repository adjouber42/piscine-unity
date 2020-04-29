using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;


public class draganddrop : MonoBehaviour, IDragHandler, IEndDragHandler
{
    // Start is called before the first frame update

    ui_script obj_ui;
    public GameObject panel;

    void Start()
    {
        obj_ui = panel.GetComponent<ui_script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.name == "canon")
        {
            if (gameManager.gm.playerEnergy >= obj_ui.prefab_canon.GetComponent<towerScript>().energy)
                GetComponent<UnityEngine.UI.Image>().color = new Color(255, 255, 255, 255);
            else
                GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 255);
        }
        if (transform.name == "gatling")
        {
            if (gameManager.gm.playerEnergy >= obj_ui.prefab_gatling.GetComponent<towerScript>().energy)
             GetComponent<UnityEngine.UI.Image>().color = new Color(255, 255, 255, 255);
            else
             GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 255);
        }
        if (transform.name == "rocket")
        {
            if (gameManager.gm.playerEnergy >= obj_ui.prefab_rocket.GetComponent<towerScript>().energy)
             GetComponent<UnityEngine.UI.Image>().color = new Color(255, 255, 255, 255);
            else
             GetComponent<UnityEngine.UI.Image>().color = new Color(255, 0, 0, 255);
        }
    }

    public void OnDrag (PointerEventData eventData)
    {
        Vector3 temp = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        temp.z = 5f;
        transform.position = temp;
    }

    public void OnEndDrag (PointerEventData eventData)
    {
        transform.localPosition = Vector3.zero;
        RaycastHit2D hit = Physics2D.Raycast(Camera.main.ScreenToWorldPoint(Input.mousePosition), Vector2.zero);

        if (hit && hit.collider.gameObject.transform.parent.gameObject.name == "empty")
        {
            if (transform.name == "canon")
                obj_ui.make_canon(hit.collider.gameObject.transform.position);
            if (transform.name == "gatling")
                obj_ui.make_gatling(hit.collider.gameObject.transform.position);
            if (transform.name == "rocket")
                obj_ui.make_rocket(hit.collider.gameObject.transform.position);
        }
    }
}
