using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sample3 : MonoBehaviour
{

	// Use this for initialization
	void Start ()
	{

//		for(int i =0;i < 10 ;i++){
//			Debug.Log (i);
//		}

//		for (int i = 0; i < 10; i += 2) {
//			Debug.Log (i);
//		}

		int x = 100;
		for (int i = 1; i <= 100; i++) {
			if (i % 2 == 1) {
				Debug.Log ("奇数" + i);
			} else {
				Debug.Log ("偶数" + i);
			}
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}
}