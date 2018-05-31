using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample4: MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{
		int[] arr = new int[5];
		int[] points = { 10, 58, 49, 30, 20 };
		int sum = 0;
		int ave = 0;

		for (int i = 0; i < points.Length; i++) {
			Debug.Log (points [i]);
			sum += points [i];
		}

		ave = sum / points.Length;
		Debug.Log ("平均点は"+ave);

	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}