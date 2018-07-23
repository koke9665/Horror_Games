using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Bottom : MonoBehaviour {
    public GameObject Text_Title;
    public Animator Fade;
    public Animator Controller;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
        if(Text_Title.active == false){
            Debug.Log("ゲームスタート");
            Controller.SetBool("Start",true);
            Invoke("Start_Animator",2F);
        }
	}
    void Start_Animator(){
        Fade.SetBool("Fade", true);
        Fade.SetBool("Start", false);
    }
}
