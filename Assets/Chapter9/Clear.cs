using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class Clear : MonoBehaviour
{
	public GameObject key;
	private bool opened;
	private bool isNear;
	public AudioClip close;

	void Start ()
	{
		opened = false;
		isNear = false;
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Fire1") && isNear && key.active == true) {
			Debug.Log ("鍵がかかっている！");
			GetComponent<AudioSource> ().PlayOneShot (close);
		}


		if (Input.GetButtonDown ("Fire1") && isNear && key.active == false) {
			if (!opened) {
				SceneManager.LoadScene ("Clear");
				Debug.Log ("車が動いた！");
			}
		}
	}

	void OnTriggerEnter (Collider theCollider)
	{
		if (theCollider.tag == "Player") {
			isNear = true;
		}
	}

	void OnTriggerExit (Collider theCollider)
	{
		if (theCollider.tag == "Player") {
			isNear = false;
		}
	}
}