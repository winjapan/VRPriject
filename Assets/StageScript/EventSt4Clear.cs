using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class EventSt4Clear : MonoBehaviour
{
    public GameObject Warp;
    public GameObject Captain;
    public Canvas PlayerCan;
    public Canvas BossCan;
    //プレイヤー吹き出しUI
    public Image playerIm;
    public Text PSay1;
    public Text PSay2;
    public Text PSay3;
    public Text PSay4;
    public Text PSay5;

    public Image lpIm;
    public Text LPSay1;
    public Text LPSay2;
    public Text LPSay3;
    public Text LPSay4;
    public Text Hint;

    public NavMeshAgent agent;

    public Canvas EventCanvas;

    public Text Timer;

    public GameObject Director;

    public float introTime;

    public GameObject EventPlayer;
    public GameObject Player;
    public GameObject Player2;
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 45;

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        introTime -= Time.deltaTime;

        if (introTime < 45)
        {
            FirstCount();
        }
        if (introTime < 40)
        {
            SecondCount();

        }

        if (introTime < 35)
        {
            ThirdCount();
        }

        if (introTime < 30)
        {
            ForthCount();
        }

        if (introTime < 25)
        {
            FifthCount();
        }

        if (introTime < 20)
        {
            SixthCount();
        }

        if (introTime < 15)
        {
            SeventhCount();
        }

        if (introTime < 10)
        {
            EightCount();
        }

        if (introTime < 5)
        {
            NinethCount();
        }

        if (introTime < 0)
        {
            NextSceneMove();
        }
    }

    void FirstCount()
    {
        playerIm.gameObject.SetActive(true);
        Player.SetActive(false);
        EventPlayer.SetActive(true);

        GameObject.Find("Lady Pirate").GetComponent<NavMeshAgent>().enabled = false;
        GameObject.Find("Lady Pirate").GetComponent<LadyPirateController>().enabled = false;
        GameObject.Find("Lady Pirate").GetComponent<LadyPirateHP>().enabled = false;
        GameObject.Find("Lady Pirate").GetComponent<LadyPirateAttack>().enabled = false;
        GameObject.Find("CaptainBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("FunnyBGM").GetComponent<AudioSource>().enabled = true;
        PlayerCan.gameObject.SetActive(false);
        BossCan.gameObject.SetActive(false);
        Timer.gameObject.SetActive(false);
    }

    void SecondCount()
    {
        PSay1.gameObject.SetActive(false);
        PSay2.gameObject.SetActive(true);
    }

    void ThirdCount()
    {
        lpIm.gameObject.SetActive(true);
        playerIm.gameObject.SetActive(false);
        PSay2.gameObject.SetActive(false);
        PSay3.gameObject.SetActive(true);

    }

    void ForthCount()
    {
        lpIm.gameObject.SetActive(false);
        LPSay1.gameObject.SetActive(false);
        LPSay2.gameObject.SetActive(true);
        playerIm.gameObject.SetActive(true);


    }

    void FifthCount()
    {
       
        PSay3.gameObject.SetActive(false);
        PSay4.gameObject.SetActive(true);

    }

    void SixthCount()
    {
        playerIm.gameObject.SetActive(false);
        PSay4.gameObject.SetActive(false);
        PSay5.gameObject.SetActive(true);

        lpIm.gameObject.SetActive(true);

    }

    void SeventhCount()
    {
        LPSay2.gameObject.SetActive(false);
        LPSay3.gameObject.SetActive(true);
    }

    void EightCount()
    {
        playerIm.gameObject.SetActive(true);

        lpIm.gameObject.SetActive(false);
        LPSay3.gameObject.SetActive(false);
        LPSay4.gameObject.SetActive(true);
    }

    void NinethCount()
    {

        playerIm.gameObject.SetActive(false);

        lpIm.gameObject.SetActive(true);
    }

    void NextSceneMove()
    {
        Player2.SetActive(true);
        EventPlayer.SetActive(false);
        //GameObject.Find("CaptainBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("FunnyBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = true;
        lpIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        Destroy(Captain);
        EventCanvas.gameObject.SetActive(false);
        Director.gameObject.SetActive(false);
        Warp.SetActive(true);
    }
}
