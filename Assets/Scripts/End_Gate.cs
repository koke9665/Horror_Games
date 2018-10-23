using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class End_Gate : MonoBehaviour {

    public Animator Gate_left;
    public Animator Gate_right;
    public GameObject whiteOut;
    private bool near=false;

	// Use this for initialization
	void Start () {
    }

	// Update is called once per frame
	void Update () {
		if(Input.GetButtonDown("Fire1") && near){
      Debug.Log("接触したよ！");
      Gate_left.SetBool("Open", false);
      Gate_right.SetBool("Open", false);
      whiteOut.active=true;
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

}
