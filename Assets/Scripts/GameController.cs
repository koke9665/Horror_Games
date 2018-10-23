using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {
    public GameObject Player_Object;
    public GameObject Enemy_Upper;
    public Animator Player;
    public Animator Player_Move;
    public AudioClip Test_beap;
    public float Count = 0;
    public float Count2 = 0;
    public int Count3 = 0;
    public float Count4 = 0;
    public float click_interval=0;
    public int GameOver_Count = 0;
    public float Player_Turn_1=0;
    public float Player_Turn_2=0;
    public float Negative_Point = 2;
    private bool Negative_Start;
    private bool Negative_Start2;
    private bool Negative_flag = true;
    private bool click_flag = false;
    public float Turn = 0;
    private float rotate;
    public GameObject GameOver;

    // Use this for initialization
    void Start() {
      GameOver_Count = Random.Range(1,5);
    }

    // Update is called once per frame
    void Update() {

      //Uターンにおけるネガティブ行為の計算
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

        //クリック連打用の処理
        	if(Input.GetButtonDown("Fire1")){
            click_flag=true;
          }

          if(click_flag){
            Count4 = Count4 + Time.deltaTime;
            if(Input.GetButtonDown("Fire1")){
            click_interval++;
            if(click_interval>5){
              Negative_Point--;
            }
          }
        }

        if(Count4>10){
          click_interval = 0;
          Count4=0;
          click_flag=false;
        }

        //時間制限の計算
        if (Count<150){

        }else if (Count < 200)
        {
            Player.SetBool("Glitch2", true);
        } else {
          //ゲームオーバー処理
          if(GameOver_Count == 1){
            Debug.Log("GameOver");
            Player.SetBool("GameOver", true);
            Invoke("GameOverTime",2F);
          }else if(GameOver_Count > 1){
            Enemy_Upper.active = true;
            Player_Move.SetBool("GameOver",true);
          }
        }

        //ネガティブポイントによるゲームオーバー
        if(Negative_Point<0){
          //ゲームオーバー処理
          if(GameOver_Count == 1){
            Debug.Log("GameOver");
            Player.SetBool("GameOver", true);
            Invoke("GameOverTime",2F);
          }else if(GameOver_Count > 1){
            Enemy_Upper.active = true;
            Player_Move.SetBool("GameOver",true);
          }

        }
    }

    void GameOverTime(){

        GameOver.active = true;
        GetComponent<AudioSource>().PlayOneShot(Test_beap);
        Invoke("Application", 1f);

    }


    void Application()
    {
        SceneManager.LoadScene("TestScene");
    }
}
