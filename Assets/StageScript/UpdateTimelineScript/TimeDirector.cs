using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.AI;

public class TimeDirector : MonoBehaviour
{
    public float totalTime = 149;
    public float fteamTime = 15;
    public float steamTime = 30;
    public float tdteamTime = 30;
    public float bossTime = 60;
    public float waitTime = 3;
    public float waitsdTime = 3;
    public float waitthTime = 3;
    public float bosswaitTime = 6;

    public AudioSource cameraAudio;

    public GameObject Gob;
    public GameObject Pirate;
    public Canvas BossCan;
   

    public GameObject LadyPirate;
    public GameObject VRPoint;

    public Text Pattern1;
    public Text Pattern2;
    public Text Pattern3;
    public Text Pattern4;

    public Text Count;
    public Text Timer;
    public Text Timer2;
    public Text Bosstime;

    public Text Cousion;
    public Image Say;
    
    private int seconds;
    private float secondsTime;

    public Canvas PlayerCan;
    public SetLadyPilate setLady;
    //村人吹き出しUI
    public Text LPSpeak1;
    public Text LPSpeak2;
    public Text LPSpeak3;
    public Image BossIm;
    //プレイヤー吹き出しUI
    public Text PlayerSpeak1;
    public Text PlayerSpeak2;
    public Text PlayerSpeak3;
    public Image PlayerIm;

    public Text PlayerKO;
    public Text LPKO;

    public GameObject EventPlayer;
    public GameObject Player;
    public GameObject Player2;

    // Start is called before the first frame update
    void Start()
    {
       
        fteamTime = 15;
        steamTime = 30;
        tdteamTime = 30;
        bossTime = 63;

        totalTime = 149;
    }

    // Update is called once per frame
    void Update()
    {

        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        totalTime -= Time.deltaTime;

        if (totalTime < 147)
        {
            Pattern1.gameObject.SetActive(true);
            Count.gameObject.SetActive(true);
            waitTime -= Time.deltaTime;
            seconds = (int)waitTime;
           Count.text = seconds.ToString();
        }

        if (totalTime < 144)
        {
            Pattern1.gameObject.SetActive(false);
            Count.gameObject.SetActive(false);

            Gob.gameObject.SetActive(true);
            Timer.gameObject.SetActive(true);
            fteamTime -= Time.deltaTime;
            seconds = (int)fteamTime;
            Timer.text = seconds.ToString();

        }

        if (totalTime < 129)
        {
            Pattern2.gameObject.SetActive(true);
            Count.gameObject.SetActive(true);

           // Destroy(Gob);
           Timer.gameObject.SetActive(false);
            waitsdTime -= Time.deltaTime;
            seconds = (int)waitsdTime; 
            Count.text = seconds.ToString();

        }

        if (totalTime < 126)
        {
            Pattern2.gameObject.SetActive(false);
            Count.gameObject.SetActive(false);
          

            Pirate.gameObject.SetActive(true);
            Timer.gameObject.SetActive(true);
            steamTime -= Time.deltaTime;
            seconds = (int)steamTime;
            Timer.text = seconds.ToString();

        }



        if (totalTime <96)
        {
            Pattern4.gameObject.SetActive(true);
            Count.gameObject.SetActive(true);

            //Destroy(Pirate);
            Timer.gameObject.SetActive(false);
            waitthTime -= Time.deltaTime;
            seconds = (int)waitthTime;
            Count.text = seconds.ToString();

        }


        if (totalTime < 93)
        {
            Pattern4.gameObject.SetActive(false);
            Count.gameObject.SetActive(false);

            PlayerIm.gameObject.SetActive(true);
            Player.SetActive(false);
            EventPlayer.SetActive(true);
            Gob.gameObject.SetActive(false);
            Pirate.gameObject.SetActive(false);

            Timer.text = seconds.ToString();

            LadyPirate.SetActive(true);

            cameraAudio.enabled = false;


            GameObject.Find("CaptainBGM").GetComponent<AudioSource>().enabled = true;
            
            GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
        }

        if (totalTime < 88)
        {
            PlayerSpeak1.gameObject.SetActive(false);
            PlayerSpeak2.gameObject.SetActive(true);
        }

        if (totalTime < 83)
        {
            PlayerIm.gameObject.SetActive(false);
            PlayerSpeak2.gameObject.SetActive(false);
            PlayerSpeak3.gameObject.SetActive(true);

            BossIm.gameObject.SetActive(true);
            
        }

        if (totalTime < 78)
        {
            LPSpeak1.gameObject.SetActive(false);
            LPSpeak2.gameObject.SetActive(true);
        }

        if (totalTime < 73)
        {
            BossIm.gameObject.SetActive(false);
            LPSpeak2.gameObject.SetActive(false);
            LPSpeak3.gameObject.SetActive(true);

            PlayerIm.gameObject.SetActive(true);
        }

        if (totalTime < 68)
        {
            BossIm.gameObject.SetActive(true);
            PlayerIm.gameObject.SetActive(false);
            PlayerSpeak3.gameObject.SetActive(false);
            PlayerKO.gameObject.SetActive(true);
        }

        if (totalTime < 63)
        {
            Player2.SetActive(true);
            EventPlayer.SetActive(false);
      
            BossIm.gameObject.SetActive(false);
            LPSpeak3.gameObject.SetActive(false);
            LPKO.gameObject.SetActive(true);
            PlayerCan.gameObject.SetActive(true);
            BossCan.gameObject.SetActive(true);
            Timer.gameObject.SetActive(true);
            bossTime -= Time.deltaTime;
            seconds = (int)bossTime;

            Bosstime.text = seconds.ToString();

            setLady.enabled = true;

            GameObject.Find("LadyPirateStart").GetComponent<AudioSource>().enabled = true;
            //GameObject.Find("ma1").GetComponent<PlayerHP>().enabled = true;
         

        }

        if (totalTime < 10)
        {
            Cousion.gameObject.SetActive(true);
            Say.gameObject.SetActive(true);
        }

        if (totalTime < 0)
        {
            SceneManager.LoadScene("GameOverScene");
        }
    }
}
