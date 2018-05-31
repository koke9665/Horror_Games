using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class KeyDoor : MonoBehaviour
{

	public GameObject key;
	private bool opened;
	private bool isNear;
	private Animator animator;
	public AudioClip open;
	public AudioClip close;

	void Start ()
	{
		opened = false;
		isNear = false;
		animator = GetComponent<Animator> ();
	}

	void Update ()
	{
		if (Input.GetButtonDown ("Fire1") && isNear && key.active == true) {
			Debug.Log ("開かない！");
			GetComponent<AudioSource> ().PlayOneShot (close);
		}


		if (Input.GetButtonDown ("Fire1") && isNear && key.active == false) {
			Debug.Log ("push");
			if (!opened) {
				animator.SetBool ("Open", true);
				GetComponent<AudioSource> ().PlayOneShot (open);
				Open ();
				Debug.Log ("開く");
			}
		}
	}

	void OnTriggerEnter (Collider theCollider)
	{
		if (theCollider.tag == "Player") {
			Debug.Log ("扉の近く");
			isNear = true;
		}
	}

	void OnTriggerExit (Collider theCollider)
	{
		if (theCollider.tag == "Player") {
			Debug.Log ("扉から離れた");
			isNear = false;
		}
	}

	void Open ()
	{
		opened = !opened;
	}
}