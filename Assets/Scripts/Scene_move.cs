using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene_move : MonoBehaviour {

    public GameObject black;
    public Animator W_Key;
    public Animator A_Key;
    public Animator S_Key;
    public Animator D_Key;
    public Animator Mouse;


    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        //Wキーボード入力判定
        if(Input.GetKey(KeyCode.W)){
            W_Key.SetBool("W_Anime", true);
        }else if(Input.GetKeyUp(KeyCode.W)){
            W_Key.SetBool("W_Anime", false);
        }

        //Aキーボード入力判定
        if (Input.GetKey(KeyCode.A))
        {
            A_Key.SetBool("A_Anime", true);
        }
        else if (Input.GetKeyUp(KeyCode.A))
        {
            A_Key.SetBool("A_Anime", false);
        }

        //Sキーボード入力判定
        if (Input.GetKey(KeyCode.S))
        {
            S_Key.SetBool("S_Anime", true);
        }
        else if (Input.GetKeyUp(KeyCode.S))
        {
            S_Key.SetBool("S_Anime", false);
        }

        //Dキーボード入力判定
        if (Input.GetKey(KeyCode.D))
        {
            D_Key.SetBool("D_Anime", true);
        }
        else if (Input.GetKeyUp(KeyCode.D))
        {
            D_Key.SetBool("D_Anime", false);
        }

        //マウス入力判定
        if (Input.GetButtonDown("Fire1"))
        {
            Mouse.SetBool("Mouse_Anime", true);
        }
        else if (Input.GetButtonUp("Fire1"))
        {
            Mouse.SetBool("Mouse_Anime", false);
        }

    }

    void OnTriggerEnter(Collider other)
	{
        black.active = true;
        Invoke("Application",1f);
	}
	void Application()
	{
        SceneManager.LoadScene("Main");
	}
}
