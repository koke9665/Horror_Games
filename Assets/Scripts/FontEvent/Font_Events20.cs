using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Font_Events20 : MonoBehaviour {

	public Text Event_Text;
	public Animator Font_Animation;
	private bool near=false;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

		if(Input.GetButtonDown("Fire1") && near&& Font_Event_Contoroller.Event_now){
							Font_Animation.SetBool("Event_On",true);
						Event_Text.text="不思議とこちら側に立つのも悪くはない";
						Font_Event_Contoroller.Event_now=false;
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
		Font_Animation.SetBool("Event_On",false);
				Invoke("messagecontroller",0.15f);
			Debug.Log("遠いぞ!");
	}
}

void messagecontroller(){
	 Font_Event_Contoroller.Event_now = true;
}
}
