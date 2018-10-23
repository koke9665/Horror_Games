using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Douzou_Random : MonoBehaviour {
	public int Douzou_haiti=0;
	public GameObject Douzou1;
	public GameObject Douzou2;
	public GameObject Douzou3;
	// Use this for initialization
	void Start () {
		Douzou_haiti = Random.Range(1,3);
	}

	// Update is called once per frame
	void Update () {
		if(Douzou_haiti==1){
			Douzou1.active = true;
		}else if(Douzou_haiti==2){
			Douzou2.active = true;
		}else if(Douzou_haiti==3){
			Douzou3.active = true;
		}
	}
}
