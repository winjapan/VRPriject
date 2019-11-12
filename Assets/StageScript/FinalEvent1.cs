using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class FinalEvent1 : MonoBehaviour
{
    public Canvas PlayerCan;
    //村人吹き出しUI
    public Text Speak1;
    public Text Speak2;
    public Text Speak3;
  
    public Image IntroIm;
    //プレイヤー吹き出しUI
    public Text PlayerSpeak1;
    public Text PlayerSpeak2;
    public Text PlayerSpeak3;
 
    public Image PlayerIm;

    public float introTime;

    public GameObject Player1;
    public GameObject EventPlayer1;
    public GameObject Player2;

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
        }
    }

    void FirstCount()
    {
        GameObject.Find("Fanny2BGM").GetComponent<AudioSource>().enabled = true;
        PlayerIm.gameObject.SetActive(true);
        PlayerCan.gameObject.SetActive(false);
        Player1.SetActive(false);
        EventPlayer1.SetActive(true);
       // GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = false;
       // GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
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
        PlayerIm.gameObject.SetActive(true);

        IntroIm.gameObject.SetActive(false);
        Speak1.gameObject.SetActive(false);
        Speak2.gameObject.SetActive(true);
    }

    void ForthCount()
    {
        IntroIm.gameObject.SetActive(true);

        PlayerIm.gameObject.SetActive(false);
        PlayerSpeak2.gameObject.SetActive(false);
        PlayerSpeak3.gameObject.SetActive(true);

    }

    void FifthCount()
    {


        PlayerIm.gameObject.SetActive(true);

        IntroIm.gameObject.SetActive(false);
        Speak2.gameObject.SetActive(false);
        Speak3.gameObject.SetActive(true);
    }

    void SixthCount()
    {

        IntroIm.gameObject.SetActive(true);


        PlayerIm.gameObject.SetActive(false);

    }

    void EndEvent()
    {
        IntroIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        Player2.SetActive(true);
        EventPlayer1.SetActive(false);

        // GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = true;
        //  GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;
        GameObject.Find("Lady Pirate Ally").GetComponent<NavMeshAgent>().enabled =true;
        GameObject.Find("Lady Pirate Ally").GetComponent<LPPointMove>().enabled = true;
        GameObject.Find("Fanny2BGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("LastBGM").GetComponent<AudioSource>().enabled = true;
        this.enabled = false;
    }
}
