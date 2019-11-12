using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FinalClearEvent : MonoBehaviour
{
    public Canvas PlayerCan;

  
    //プレイヤー吹き出しUI
    public Text PlayerSpeak1;
    public Text PlayerSpeak2;
    public Text PlayerSpeak3;
    public Text PlayerSpeak4;

    public Image PlayerIm;

    public Image UniIm;
    public Text UniSpeak1;
    public Text UniSpeak2;
    public Text UniSpeak3;

    public GameObject Allay;
    public GameObject ClearPoint;

    public float introTime;

    public Text intro;

    public GameObject Player5;
    public GameObject EventPlayer5;

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
            EighthCount();
        }

        if (introTime < 5)
        {
            NinethCount();
        }

        if (introTime < 0)
        {
            EndEvent();
        }
    }

    void FirstCount()
    {
        UniIm.gameObject.SetActive(true);
        Player5.SetActive(false);
        EventPlayer5.SetActive(true);
    }

    void SecondCount()
    {
        PlayerIm.gameObject.SetActive(true);

        UniIm.gameObject.SetActive(false);
        UniSpeak1.gameObject.SetActive(false);
        UniSpeak2.gameObject.SetActive(true);
    }

    void ThirdCount()
    {
       

        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak1.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(true);
    }

    void ForthCount()
    {

        PlayerIm.gameObject.SetActive(true);


        Allay.SetActive(false);
        ClearPoint.SetActive(false);
        GameObject.Find("FannyBGM").GetComponent<AudioSource>().enabled = true;
        GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = false;

    }

    void FifthCount()
    {

        intro.gameObject.SetActive(true);
        UniIm.gameObject.SetActive(true);
        GameObject.Find("unitychan").GetComponent<AngryUnityChan>().enabled = true;


        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(false);
        PlayerSpeak3.gameObject.SetActive(true);

    }

    void SixthCount()
    {

        UniIm.gameObject.SetActive(false);
        UniSpeak2.gameObject.SetActive(false);
        UniSpeak3.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(true);
    }

    void SeventhCount()
    {
        intro.gameObject.SetActive(false);
        UniIm.gameObject.SetActive(true);

        GameObject.Find("unitychan").GetComponent<AngryUnityChan>().enabled = false;
        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
        PlayerCan.gameObject.SetActive(false);
        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak3.gameObject.SetActive(false);
        PlayerSpeak4.gameObject.SetActive(true);
    }

    void EighthCount()
    {
        PlayerIm.gameObject.SetActive(true);
        UniIm.gameObject.SetActive(false);
    }

    void NinethCount()
    {

        PlayerIm.gameObject.SetActive(false);

    }


    void EndEvent()
    {

        SceneManager.LoadScene("ClearScene");

    }

}
