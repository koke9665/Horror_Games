using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Douzou : MonoBehaviour {
	public GameObject Douzou2;
	public int Douzou_haiti=0;
	private bool near = false;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
 if (Input.GetButtonDown("Fire1") && near){
	 Douzou2.active =false;
 }
	}

	void OnTriggerEnter(Collider theCollider)
{
		if (theCollider.tag == "Player")
		{
			near=true;
				Debug.Log("近いぞ！");
		}
}


void OnTriggerExit(Collider theCollider)
{
	if (theCollider.tag == "Player")
	{
		near=false;
			Debug.Log("遠いぞ!");
	}
}
}
