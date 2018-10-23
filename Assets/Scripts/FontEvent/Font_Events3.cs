using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Font_Events3 : MonoBehaviour {

	public Text Event_Text;
	public GameObject Douzou1;

	public Animator Font_Animation;
	private bool near=false;

	private int Douzou_haiti=0;
	public GameObject Douzou2;
	public GameObject Douzou3;
	public GameObject Douzou4;

	// Use this for initialization
	void Start () {
Douzou1.active=false;
		//銅像の配置を決定
	Douzou_haiti = Random.Range(1,3);
	if(Douzou_haiti==1){
		Douzou2.active = true;
	}else if(Douzou_haiti==2){
		Douzou3.active = true;
	}else if(Douzou_haiti==3){
		Douzou4.active = true;
	}
	}

	// Update is called once per frame
	void Update () {


		if(Input.GetButtonDown("Fire1") && near && Font_Event_Contoroller.Event_now){
			if(Douzou1.active == false){
							Font_Animation.SetBool("Event_On",true);
						Event_Text.text="何かが足りない・・・";
					
					}
		}

		if(Douzou_haiti==1){

		if(Input.GetButtonDown("Fire1") && near && Douzou2.active == false && Font_Event_Contoroller.Event_now){
			Douzou1.active=true;
			Font_Animation.SetBool("Event_On",true);
		Event_Text.text="見られている気がする・・・";
		Font_Event_Contoroller.Event_now=false;
		}

		}else if(Douzou_haiti==2){

			if(Input.GetButtonDown("Fire1") && near && Douzou3.active == false&& Font_Event_Contoroller.Event_now){
			Douzou1.active=true;
			Font_Animation.SetBool("Event_On",true);
			Event_Text.text="見られている気がする・・・";
			Font_Event_Contoroller.Event_now=false;
			}

		}else if(Douzou_haiti==3){

			if(Input.GetButtonDown("Fire1") && near && Douzou4.active == false&& Font_Event_Contoroller.Event_now){
			Douzou1.active=true;
			Font_Animation.SetBool("Event_On",true);
			Event_Text.text="見られている気がする・・・";
			Font_Event_Contoroller.Event_now=false;
			}
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
