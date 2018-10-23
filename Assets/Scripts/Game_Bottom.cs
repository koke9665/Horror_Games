using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Game_Bottom : MonoBehaviour {
    public GameObject Text_Title;
    public GameObject White;
    public GameObject KeyBord;
    public GameObject KeyBord_w;
    public GameObject KeyBord_a;
    public GameObject KeyBord_s;
    public GameObject KeyBord_d;
    public GameObject Mouse;
    public GameObject Mouse_Type;
    public Animator White_Fade;
    public Animator Fade;
    public Animator Controller;
	// Use this for initialization
	void Start () {
        White.active = false;
    KeyBord.active=false;
    KeyBord_w.active = false;
        KeyBord_a.active = false;
        KeyBord_s.active = false;
        KeyBord_d.active = false;
        Mouse.active=false;
    Mouse_Type.active = false;
	}

	// Update is called once per frame
	void Update () {
        if(Text_Title.active == false){
            White.active = true;
            Debug.Log("ゲームスタート");
            Controller.SetBool("Start",true);
            Fade.SetBool("Fade", true);
            White_Fade.SetBool("FadeOut", true);
            Invoke("Fade_Out",1F);
            Invoke("Start_Animator",2F);
        }
	}

    void Fade_Out(){


    }

    void Start_Animator(){
        KeyBord.active=true;
        KeyBord_w.active = true;
        KeyBord_a.active = true;
        KeyBord_s.active = true;
        KeyBord_d.active = true;
        Mouse.active=true;
        Mouse_Type.active = true;
        Fade.SetBool("Fade", true);
        Fade.SetBool("Start", false);
    }
}
