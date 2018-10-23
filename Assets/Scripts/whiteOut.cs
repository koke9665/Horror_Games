using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class whiteOut : MonoBehaviour {

	public Animator fadeOut;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider theCollider)
{
		if (theCollider.tag == "Player")
		{

				fadeOut.SetBool("fadeOut",true);
		}
}
}
