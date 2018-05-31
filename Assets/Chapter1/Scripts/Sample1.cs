using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample1 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("hello world");
		int a = 1;
		int b = 2;
		int sum = 0;
		sum = a + b;
		Debug.Log ("sumは" + sum);
		float c = 3.9f;
		Debug.Log (c);
		sum = a + (int)c;
		Debug.Log ("sumは" + sum);

		string d = "おはよう";
		Debug.Log (d);
	}

	// Update is called once per frame
	void Update ()
	{

	}
}
