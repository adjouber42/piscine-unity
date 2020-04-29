using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void load()
	{
		SceneManager.LoadScene(1);
	}

	public void quit()
	{
		Application.Quit();
	}
}
