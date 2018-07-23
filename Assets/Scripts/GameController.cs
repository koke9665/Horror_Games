using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GameObject Player_Object;
    public Animator Player;
    public AudioClip Test_beap;
    public float Count = 0;
    public float Count2 = 0;
    public int Count3 = 0;
    public float Player_Turn_1=0;
    public float Player_Turn_2=0;
    public float Negative_Point = 2;
    private bool Negative_Start;
    private bool Negative_Start2;
    private bool Negative_flag = true;
    public float Turn = 0;
    private float rotate;
    public GameObject GameOver;

    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        Count = Count + Time.deltaTime;
        float Player_Rotate = Player_Object.transform.localEulerAngles.y;
        Count2 = Count2 + Time.deltaTime;
        if (Count2 > 1) {
            Count3 += 1;
            if (Negative_Start)
            {
                Player_Turn_1 = Player_Rotate;
                Negative_Start = false;
            }
            Count2 = 0;
        }

        if (Count3 == 5) {
            if (Negative_Start2)
            {
                Player_Turn_2 = Player_Rotate;
                Negative_Start2 = false;
            }
            Count3 = 0;
            Negative_flag = true ;
        }


        if (Negative_flag)
        {
            if (Player_Turn_1 < Player_Turn_2)
            {
                Turn = Player_Turn_2 - Player_Turn_1;
                if (Turn > 150)
                {
                    Negative_Point--;
                    Turn = 0;
                    Negative_flag = false;
                }
            }
            else if (Player_Turn_2 < Player_Turn_1)
            {
                Turn = Player_Turn_1 - Player_Turn_2;
                if (Turn > 150)
                {
                    Negative_Point--;
                    Turn = 0;
                    Negative_flag = false;
                }
            }
            Negative_Start = true;
            Negative_Start2 = true;
        }


        if (Count<100){

        }else if (Count < 200)
        {
            Player.SetBool("Glitch2", true);
        } else {
            Debug.Log("GameOver");
            Player.SetBool("GameOver", true);
            Invoke("GameOverTime",2F);
        }   
    }

    void GameOverTime(){
        GameOver.active = true;
        GetComponent<AudioSource>().PlayOneShot(Test_beap);
        Invoke("Application", 1f);
    }

    void Application()
    {
        SceneManager.LoadScene("DemoGameOver");
    }
}
