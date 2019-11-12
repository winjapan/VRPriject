using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class St3BossClearEvent : MonoBehaviour
{

    public GameObject Sheriff;
    public GameObject Boss;
   
    public Canvas BossCan;
    //ST３ボス吹き出しUI
    public Image playerIm;
    public Text PSay1;
    public Text PSay2;
    public Text PSay3;
    public Text PSay4;
    public Text PSay5;

    public Image cowIm;
    public Text CSay1;
    public Text CSay2;
    public Text CSay3;
    public Text CSay4;

    public NavMeshAgent agent;

    public Canvas EventCanvas;

    public GameObject Director;

    public GameObject EventPlayer;
    public GameObject Player;

    public float introTime;
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

        if (introTime < 10 )
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
            introTime = 0;
        }
    }

    void FirstCount()
    {
        playerIm.gameObject.SetActive(true);
        Player.gameObject.SetActive(false);
        EventPlayer.SetActive(true);

        GameObject.Find("Cowboy").GetComponent<NavMeshAgent>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<CowBoyController>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<BossAttack>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<BossAttack>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<CowBoyHP>().enabled = false;
        GameObject.Find("Cowboy").GetComponent<BossAttack>().enabled = false;


        BossCan.gameObject.SetActive(false);
    }

    void SecondCount()
    {
        PSay1.gameObject.SetActive(false);
        PSay2.gameObject.SetActive(true);
    }

    void ThirdCount()
    {
        cowIm.gameObject.SetActive(true);
        playerIm.gameObject.SetActive(false);
        PSay2.gameObject.SetActive(false);
        PSay3.gameObject.SetActive(true);

    }

    void ForthCount()
    {

        CSay1.gameObject.SetActive(false);
        CSay2.gameObject.SetActive(true);

    }

    void FifthCount()
    {
        cowIm.gameObject.SetActive(false);
        CSay2.gameObject.SetActive(false);
        CSay3.gameObject.SetActive(true);

        playerIm.gameObject.SetActive(true);
    }

    void SixthCount()
    {
        playerIm.gameObject.SetActive(false);
        PSay3.gameObject.SetActive(false);
        PSay4.gameObject.SetActive(true);

        cowIm.gameObject.SetActive(true);

    }

    void SeventhCount()
    {
        playerIm.gameObject.SetActive(true);

        cowIm.gameObject.SetActive(false);
        CSay3.gameObject.SetActive(false);
        CSay4.gameObject.SetActive(true);
    }

    void EightCount()
    {
        PSay4.gameObject.SetActive(false);
        PSay5.gameObject.SetActive(true);
    }

    void NinethCount()
    {
        playerIm.gameObject.SetActive(false);
        cowIm.gameObject.SetActive(true);
    }

    void NextSceneMove()
    {
        cowIm.gameObject.SetActive(false);
        Player.gameObject.SetActive(true);
        EventPlayer.SetActive(false);
        Destroy(Boss);
        EventCanvas.gameObject.SetActive(false);
        Destroy(Director);
        Sheriff.SetActive(true);
    }
}
