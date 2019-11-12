using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2Event : MonoBehaviour
{
    public Canvas PlayerCan;
    public Text Intro1;
    public Text Intro2;
    public Text Intro3;
    public Text IntroEx;
    public Image IntroIm;

    public float introTime;
    public GameObject Tunning;
    public GameObject EventPlayer;
    public GameObject Player;
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 18;
        GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = false;
        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
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

        if (introTime < 15)
        {
            FirstCount();
        }
        if (introTime < 10)
        {
            SecondCount();

        }

        if (introTime < 5)
        {
            FinishIntroduction();
        }

        if (introTime < 0)
        {
            Boss1();
        }
    }

    void FirstCount()
    {
        Intro1.gameObject.SetActive(true);
        IntroEx.gameObject.SetActive(true);
        PlayerCan.gameObject.SetActive(false);
        IntroIm.gameObject.SetActive(true);
        Tunning.SetActive(false);
    }

    void SecondCount()
    {
        Intro2.gameObject.SetActive(true);
        Intro1.gameObject.SetActive(false);
        IntroEx.gameObject.SetActive(false);
    }

    void FinishIntroduction()
    {
        Intro3.gameObject.SetActive(true); 
        Intro2.gameObject.SetActive(false);
      
    }

    void Boss1()
    {
        Player.SetActive(true);
        EventPlayer.SetActive(false);
        IntroIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        Tunning.SetActive(true);
        GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = true;
        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;
        GameObject.Find("InsectBGM").GetComponent<AudioSource>().enabled = true;
        this.enabled = false;
    }
}
