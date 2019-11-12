using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class St4ColEvent : MonoBehaviour
{

    public Canvas PlayerCan;
    //村人吹き出しUI
    public Text Speak1;
    public Text Speak2;
    public Text Speak3;
    public Text Speak4;
    public Image IntroIm;
    //プレイヤー吹き出しUI
    public Text PlayerSpeak1;
    public Text PlayerSpeak2;
    public Text PlayerSpeak3;
    public Text PlayerSpeak4;
    public Image PlayerIm;

    public GameObject NPC;

    public float introTime;
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 42;
       

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

        if (introTime < 40)
        {
            FirstCount();
        }
        if (introTime < 35)
        {
            SecondCount();

        }

        if (introTime < 30)
        {
            ThirdCount();
        }

        if (introTime < 25)
        {
            ForthCount();
        }

        if (introTime < 20)
        {
            FifthCount();
        }

        if (introTime < 15)
        {
            SixthCount();
        }

        if (introTime < 10)
        {
            SeventhCount();
        }

        if (introTime < 5)
        {
            EighthCount();
        }

        if (introTime < 0)
        {
            EndEvent();
        }
    }

    void FirstCount()
    {
       // GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = false;
       // GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
        PlayerCan.gameObject.SetActive(false);
        PlayerIm.gameObject.SetActive(true);
    }

    void SecondCount()
    {
        IntroIm.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak1.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(true);
    }

    void ThirdCount()
    {
       Speak1.gameObject.SetActive(false);
       Speak2.gameObject.SetActive(true);
    }

    void ForthCount()
    {
        IntroIm.gameObject.SetActive(false);
        Speak2.gameObject.SetActive(false);
        Speak3.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(true);

    }

    void FifthCount()
    {
        IntroIm.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(false);
        PlayerSpeak3.gameObject.SetActive(true);
    }

    void SixthCount()
    {
        IntroIm.gameObject.SetActive(false);
        Speak3.gameObject.SetActive(false);
        Speak4.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(true);

    }

    void SeventhCount()
    {
        IntroIm.gameObject.SetActive(true);


        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak3.gameObject.SetActive(false);
        PlayerSpeak4.gameObject.SetActive(true);
    }

    void EighthCount()
    {
        IntroIm.gameObject.SetActive(false);


        PlayerIm.gameObject.SetActive(true);

    }

    void EndEvent()
    {
        PlayerIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        NPC.SetActive(false);
    
      //  GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = true;
       // GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;
      
    }
}
