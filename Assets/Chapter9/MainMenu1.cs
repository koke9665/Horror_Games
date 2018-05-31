using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu1 : MonoBehaviour
{

	public bool quit = false;

	void Start ()
	{
		Cursor.visible = true;
		Cursor.lockState = CursorLockMode.Confined;
	}

	void OnMouseEnter ()
	{

		GetComponent<Renderer> ().material.color = Color.red;

	}

	void OnMouseExit ()
	{

		GetComponent<Renderer> ().material.color = Color.white;

	}

	void OnMouseUp ()
	{

		if (quit == true) {
			Application.Quit ();
			Debug.Log ("quitしました");
		} else {
			SceneManager.LoadScene ("Chapter9");
		}

	}
}