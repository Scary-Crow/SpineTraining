using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Go : MonoBehaviour
{
	// Просто переход между сценами, вешать на Canvas

	public void ChangeScene(string name)
	{
		SceneManager.LoadScene(name);
	}
}
