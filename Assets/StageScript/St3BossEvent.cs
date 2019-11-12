using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class St3BossEvent : MonoBehaviour
{
    public Canvas PlayerCan;
    public Canvas BossCan;
    //ST３ボス吹き出しUI
    public Text Speak1;
    public Text KOTex;
   
    public Image IntroIm;
    //プレイヤー吹き出しUI
    public Text PlayerSpeak1;
    public Text PlayerSpeak2;
    public Text PlayerSpeak3;
    public Text SayClear;
  
    public Image PlayerIm;
    public GameObject EventPlayer;
    public GameObject Player;
    public float introTime;
    public Animator playerAniator;
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 20;
        //GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = true;
        //GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = false;
        //GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.Find("Cowboy").GetComponent<CowBoyController>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<NavMeshAgent>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<CowBoyHP>().enabled = false;
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

        if (introTime < 20)
        {
            FirstCount();
        }
        if (introTime < 15)
        {
            SecondCount();

        }

        if (introTime < 10)
        {
            ThirdCount();
        }

        if (introTime < 5)
        {
            ForthCount();
        }

        if (introTime < 0)
        {
            EndEvent();
            introTime = 0;
        }
    }

    void FirstCount()
    {
        PlayerIm.gameObject.SetActive(true);


    }

    void SecondCount()
    {

        PlayerSpeak1.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(true);

    }

    void ThirdCount()
    {
        IntroIm.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(false);
        PlayerSpeak3.gameObject.SetActive(true);
    }

    void ForthCount()
    {
        IntroIm.gameObject.SetActive(false);
        KOTex.gameObject.SetActive(true);
        Speak1.gameObject.SetActive(false);


        PlayerIm.gameObject.SetActive(true);

    }

    void EndEvent()
    {
        PlayerIm.gameObject.SetActive(false);
        SayClear.gameObject.SetActive(true);
        PlayerSpeak3.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        BossCan.gameObject.SetActive(true);
        EventPlayer.SetActive(false);
        Player.SetActive(true);
        playerAniator.enabled = false;
        GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = true;
        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;
        GameObject.Find("Cowboy").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Find("Cowboy").GetComponent<CowBoyController>().enabled = true;
        GameObject.Find("Cowboy").GetComponent<NavMeshAgent>().enabled = true;
        GameObject.Find("Cowboy").GetComponent<CowBoyHP>().enabled = true;
        GameObject.Find("BossSE").GetComponent<AudioSource>().enabled = false;
    }
}
