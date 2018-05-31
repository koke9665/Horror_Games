using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_move : MonoBehaviour {

    public GameObject black;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnTriggerEnter(Collider other)
	{
        black.active = true;
        Invoke("Application",1f);
	}
	void Application()
	{
        SceneManager.LoadScene("Main");
	}
}
