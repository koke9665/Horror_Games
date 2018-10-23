using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Book_Random : MonoBehaviour {
public static int book_hint_haiti;
public GameObject book_hint1;
public GameObject book_hint2;
public GameObject book_hint3;
public GameObject input_Object;
public GameObject Botton_Object;
public Animator input_Field;
public Animator Button;
public Animator Player_Move;
public bool near=false;
public bool Input_upper=true;

	// Use this for initialization
	void Start () {
		book_hint_haiti = Random.Range(1,3);
		book_hint1.active=false;
		book_hint2.active=false;
		book_hint3.active=false;
						input_Object.active=false;
						Botton_Object.active=false;
						if(book_hint_haiti==1){
							book_hint1.active=true;
						}else if(book_hint_haiti==2){
							book_hint2.active=true;
						}else if(book_hint_haiti==3){
							book_hint3.active=true;
						}
	}

	// Update is called once per frame
	void Update () {

			if(Input.GetButtonDown("Fire1") && near && Input_upper){
				input_Object.active=true;
				Botton_Object.active=true;
								Player_Move.SetBool("GameOver",true);
				input_Field.SetBool("Fade",true);
				Input_upper=false;
			}
			if(Input_upper == false){
				Cursor.lockState = CursorLockMode.None;
					Cursor.visible = true;
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

public void Retrun_Play()
{
	input_Object.active=false;
	Botton_Object.active=false;
					Input_upper=true;
						Cursor.visible = false;
						Cursor.lockState = CursorLockMode.Locked;
						Player_Move.SetBool("GameOver",false);
}
}
