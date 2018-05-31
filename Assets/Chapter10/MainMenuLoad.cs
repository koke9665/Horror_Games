using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuLoad : MonoBehaviour
{
	// Use this for initialization
	void Start ()
	{
		StartCoroutine (MainManuLoad ());
	}

	IEnumerator MainManuLoad ()
	{
		yield return new WaitForSeconds (5f);
		SceneManager.LoadScene ("MainMenu");
	}
}
