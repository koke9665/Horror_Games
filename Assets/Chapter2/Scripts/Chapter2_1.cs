using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Chapter2_1 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		Hello ();
		CallName ("太郎");
		Debug.Log (Add (100, 10));
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void Hello ()
	{
		Debug.Log ("こんにちは!");
	}

	string Hello (string n)
	{
		return n;
	}

	void CallName (string name)
	{
		Debug.Log ("こんにちは" + name);
	}

	int Add (int x, int y)
	{
		int z = x + y;
		return z;
	}
}
