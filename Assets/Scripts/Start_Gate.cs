using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Start_Gate : MonoBehaviour {

    public Animator Gate_left;
    public Animator Gate_right;
    public Animator Gritch;
    bool start;

	// Use this for initialization
	void Start () {
        start = true;
    }
	
	// Update is called once per frame
	void Update () {

    }

     void OnTriggerEnter(Collider theCollider)
    {
        if (theCollider.tag == "Player" && start == true)
        {
            Debug.Log("接触したよ！");
            Gate_left.SetBool("Open", true);
            Gate_right.SetBool("Open", true);
            Gritch.SetTrigger("WeakGlitch");
            start = false;
        }
    }

}
