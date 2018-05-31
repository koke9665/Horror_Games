using UnityEngine;
using System.Collections;

public class Key : MonoBehaviour
{
	private bool isNear;
	public AudioClip keySound;
	public GameObject theKey;

	void Start(){
		isNear = false;
	}

	void Update ()
	{
		if (isNear == true) {
			if (Input.GetButtonDown ("Fire1")) {
				Debug.Log ("鍵を取得！");
				AudioSource.PlayClipAtPoint (keySound, transform.position);
				theKey.active = false;
			}
		}
	}

	void OnTriggerEnter (Collider theCollider)
	{
		if (theCollider.tag == "Player") {
			isNear = true;
			Debug.Log ("鍵の近く");
		}
	}

	void OnTriggerExit (Collider theCollider)
	{
		if (theCollider.tag == "Player") {
			isNear = true;
			Debug.Log ("鍵から離れた");
		}
	}
}