using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class book_pazzle : MonoBehaviour {

	public string str;
	public InputField inputField;
	public Text text;
	public int mozi;

	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		Debug.Log(Book_Random.book_hint_haiti);
}
	public void nazotoki(){
		str = inputField.text;
		if(str == "dead_or"){
			text.text = str;
		inputField.text = "";
		}

	}
}
