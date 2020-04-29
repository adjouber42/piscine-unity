using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ui_script : MonoBehaviour
{
    public GameObject prefab_canon;
    public GameObject prefab_gatling;
    public GameObject prefab_rocket;

    private GameObject text_hp;
    private GameObject text_energy;

    private GameObject canon_range;
    private GameObject canon_dmg;
    private GameObject canon_time;
    private GameObject canon_energy;

    private GameObject gatling_range;
    private GameObject gatling_dmg;
    private GameObject gatling_time;
    private GameObject gatling_energy;

    private GameObject rocket_range;
    private GameObject rocket_dmg;
    private GameObject rocket_time;
    private GameObject rocket_energy;

    // Start is called before the first frame update
    void Start()
    {
        text_hp = GameObject.Find("hp");
        text_energy = GameObject.Find("energy");

        canon_range = GameObject.Find("canonrange");
        canon_dmg = GameObject.Find("canondmg");
        canon_time = GameObject.Find("canontime");
        canon_energy = GameObject.Find("canonenergy");

        gatling_range = GameObject.Find("gatlingrange");
        gatling_dmg = GameObject.Find("gatlingdmg");
        gatling_time = GameObject.Find("gatlingtime");
        gatling_energy = GameObject.Find("gatlingenergy");

        rocket_range = GameObject.Find("rocketrange");
        rocket_dmg = GameObject.Find("rocketdmg");
        rocket_time = GameObject.Find("rockettime");
        rocket_energy = GameObject.Find("rocketenergy");

    }

    // Update is called once per frame
    void Update()
    {
		text_energy.GetComponent<UnityEngine.UI.Text>().text = gameManager.gm.playerEnergy.ToString();
		text_hp.GetComponent<UnityEngine.UI.Text>().text = gameManager.gm.playerHp.ToString();

        canon_range.GetComponent<UnityEngine.UI.Text>().text = prefab_canon.GetComponent<towerScript>().range.ToString();
        canon_dmg.GetComponent<UnityEngine.UI.Text>().text = prefab_canon.GetComponent<towerScript>().damage.ToString();
        canon_time.GetComponent<UnityEngine.UI.Text>().text = prefab_canon.GetComponent<towerScript>().fireRate.ToString();
        canon_energy.GetComponent<UnityEngine.UI.Text>().text = prefab_canon.GetComponent<towerScript>().energy.ToString();

        gatling_range.GetComponent<UnityEngine.UI.Text>().text = prefab_gatling.GetComponent<towerScript>().range.ToString();
        gatling_dmg.GetComponent<UnityEngine.UI.Text>().text = prefab_gatling.GetComponent<towerScript>().damage.ToString();
        gatling_time.GetComponent<UnityEngine.UI.Text>().text = prefab_gatling.GetComponent<towerScript>().fireRate.ToString();
        gatling_energy.GetComponent<UnityEngine.UI.Text>().text = prefab_gatling.GetComponent<towerScript>().energy.ToString();

        rocket_range.GetComponent<UnityEngine.UI.Text>().text = prefab_rocket.GetComponent<towerScript>().range.ToString();
        rocket_dmg.GetComponent<UnityEngine.UI.Text>().text = prefab_rocket.GetComponent<towerScript>().damage.ToString();
        rocket_time.GetComponent<UnityEngine.UI.Text>().text = prefab_rocket.GetComponent<towerScript>().fireRate.ToString();
        rocket_energy.GetComponent<UnityEngine.UI.Text>().text = prefab_rocket.GetComponent<towerScript>().energy.ToString();
    }

    public void make_canon(Vector3 position)
    {
        if (gameManager.gm.playerEnergy >= prefab_canon.GetComponent<towerScript>().energy)
        {
            Instantiate(prefab_canon, position, Quaternion.identity);
            gameManager.gm.playerEnergy -= prefab_canon.GetComponent<towerScript>().energy;
        }
    }

    public void make_gatling(Vector3 position)
    {
        if (gameManager.gm.playerEnergy >= prefab_gatling.GetComponent<towerScript>().energy)
        {
            Instantiate(prefab_gatling, position, Quaternion.identity);
            gameManager.gm.playerEnergy -= prefab_gatling.GetComponent<towerScript>().energy;
        }
    }

    public void make_rocket(Vector3 position)
    {
        if (gameManager.gm.playerEnergy >= prefab_rocket.GetComponent<towerScript>().energy)
        {
            Instantiate(prefab_rocket, position, Quaternion.identity);
            gameManager.gm.playerEnergy -= prefab_rocket.GetComponent<towerScript>().energy;
        }
    }
}
