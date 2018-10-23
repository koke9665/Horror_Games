using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOver_Audio_Contoroller : MonoBehaviour {

	public AudioClip Enviroment_Audio1;
	public AudioClip Enviroment_Audio2;
	public AudioClip Enviroment_Audio3;
	public AudioClip Enviroment_Audio4;
	public AudioClip Enviroment_Audio5;
	public AudioClip Enviroment_Audio6;
	public AudioClip Enviroment_Audio7;
	public int Audio_Move;

	// Use this for initialization
	void Start () {
	Audio_Move = Random.Range(0,15);
	if(Audio_Move==0){
	GetComponent<AudioSource>().PlayOneShot(Enviroment_Audio1);
}else if(Audio_Move==1){
	GetComponent<AudioSource>().PlayOneShot(Enviroment_Audio2);
}else if(Audio_Move==2){
	GetComponent<AudioSource>().PlayOneShot(Enviroment_Audio3);
}else if(Audio_Move==3){
	GetComponent<AudioSource>().PlayOneShot(Enviroment_Audio4);
}else if(Audio_Move==4){
	GetComponent<AudioSource>().PlayOneShot(Enviroment_Audio5);
}else if(Audio_Move==5){
	GetComponent<AudioSource>().PlayOneShot(Enviroment_Audio6);
}else if(Audio_Move==6){
	GetComponent<AudioSource>().PlayOneShot(Enviroment_Audio7);
}

	}

	// Update is called once per frame
	void Update () {


	}
}
