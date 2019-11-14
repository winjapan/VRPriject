using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class FinalBossEvent : MonoBehaviour
{
    public GameObject LastBoss;
    //村人吹き出しUI
    public Text Speak1;
    public Text Speak2;
    //public Text Speak3;

    public Image LPIm;
    //プレイヤー吹き出しUI
    public Text PlayerSpeak1;
    public Text PlayerSpeak2;
   // public Text PlayerSpeak3;

    public Image PlayerIm;

    public Image UniIm;

    public float introTime;

    public GameObject AllayPoint;

    public Canvas PlayerCan;
    public Canvas BossCan;
    public GameObject Player4;
    public GameObject EventPlayer3;
    public GameObject Player3;
    public AudioSource Playeraudio;
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 25;

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

        if (introTime < 25)
        {
            FirstCount();
        }
        if (introTime < 20)
        {
            SecondCount();
        }

        if (introTime < 15)
        {
            ThirdCount();
        }

        if (introTime < 10)
        {
            ForthCount();
        }

        if (introTime < 5)
        {
            FifthCount();
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
        PlayerCan.gameObject.SetActive(false);
        Player4.SetActive(false);
        EventPlayer3.SetActive(true);
    
        // GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = false;
        // GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
    }

    void SecondCount()
    {
        UniIm.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak1.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(true);
    }

    void ThirdCount()
    {
        LPIm.gameObject.SetActive(true);

        UniIm.gameObject.SetActive(false);

    }

    void ForthCount()
    {
        LPIm.gameObject.SetActive(false);
        Speak1.gameObject.SetActive(false);
        Speak2.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(true);

    }

    void FifthCount()
    {


        LPIm.gameObject.SetActive(true);


        PlayerIm.gameObject.SetActive(false);
    }

    void EndEvent()
    {
        LPIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        EventPlayer3.SetActive(false);
        Player3.SetActive(true);
        GameObject.Find("LastBoss").GetComponent<WizardAttack>().enabled = true;
      
        Playeraudio.enabled = true;
        this.enabled = false;
       
    }
}
