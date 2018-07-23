using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class MainMenu2 : MonoBehaviour
{

	public bool quit = false;
    public GameObject Light;
    public Animator Spot_Light;
    public GameObject Text_Title;
    public GameObject Text2;
    public AudioClip Start_Se;
    AudioClip audioSource;

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
            Debug.Log("クリックされました");
            GetComponent<AudioSource>().PlayOneShot(Start_Se);
            Light.active = true;
            Spot_Light.SetBool("Start",true);
            Invoke("Text_Fade",2F);

		}

	}
    void Text_Fade(){
        Text_Title.active = false;
        Text2.active = false;
    }
}