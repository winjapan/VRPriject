using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalEvent2 : MonoBehaviour
{
    public Canvas PlayerCan;
    //村人吹き出しUI
    public Text Speak1;

    public Image LPIm;
    //プレイヤー吹き出しUI
    public Text PlayerSpeak1;
    public Text PlayerSpeak2;
  

    public Image PlayerIm;

    public Image UniIm;
    public Text Unisp1;
    public Text UniSp2;
    public Text UniSp3;

    public float introTime;
    public GameObject Player2;
    public GameObject EventPlayer2;
    public GameObject Player4;
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 40;

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
            EndEvent();
            introTime = 0;
        }
    }

    void FirstCount()
    {
        PlayerCan.gameObject.SetActive(false);
        UniIm.gameObject.SetActive(true);
        Player2.SetActive(false);
        EventPlayer2.SetActive(true);
    }

    void SecondCount()
    {
        PlayerIm.gameObject.SetActive(true);
        UniIm.gameObject.SetActive(false);
        Unisp1.gameObject.SetActive(false);
        UniSp2.gameObject.SetActive(true);
    }

    void ThirdCount()
    {
        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak1.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(true);

        UniIm.gameObject.SetActive(true);

    }

    void ForthCount()
    {
        PlayerIm.gameObject.SetActive(true);

        UniIm.gameObject.SetActive(false);
        UniSp2.gameObject.SetActive(false);
        UniSp3.gameObject.SetActive(true);

    }

    void FifthCount()
    {


        PlayerIm.gameObject.SetActive(false);

        UniIm.gameObject.SetActive(true);
       
    }

    void SixthCount()
    {

        UniIm.gameObject.SetActive(false);


        LPIm.gameObject.SetActive(true);

    }

    void EndEvent()
    {
        PlayerCan.gameObject.SetActive(true);
        LPIm.gameObject.SetActive(false);
        GameObject.Find("Lady Pirate Ally").GetComponent<LPPointMove>().enabled =false;
        this.enabled = false;
        Player4.SetActive(true);
        EventPlayer2.SetActive(false);

    }

}
