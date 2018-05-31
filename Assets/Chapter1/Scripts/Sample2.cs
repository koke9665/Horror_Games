using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample2 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		int a = 1;
		int hp = 100;
		if (a == 2) {
			Debug.Log ("２だよ");
		} else {
			Debug.Log ("１だよ");
		}

		hp -= 70;

		if (hp <= 50) {
			Debug.Log ("ひんし！" + hp);
		} else {
			Debug.Log ("だいじょうぶ！" + hp);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}
