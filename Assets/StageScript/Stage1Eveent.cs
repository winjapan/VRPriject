using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage1Eveent : MonoBehaviour
{
    public Canvas PlayerCan;
    public Text Intro1;
    public Text Intro2;
    public Text Intro3;
    public Image IntroIm;

    public float introTime;
    public GameObject Tunning;
    public GameObject EventCamera;
    public GameObject Player;

    // Start is called before the first frame update
    void Awake()
    {
        introTime = 15;
        GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = true;
        GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = false;
        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = false;
        //GameObject.Find("ma").GetComponent<>().enabled = false;

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

        if (introTime <15)
        {
            Zero();
        }
        if (introTime < 10)
        {
            FirstCount();
        }

        if (introTime < 5)
        {
            SecondCount();
        }

        if (introTime < 0)
        {
           FinishIntroduction();
        }
    }

    void Zero()
    {
        //Tunning.SetActive(false);
    }

    void FirstCount()
    {
        Intro2.gameObject.SetActive(true);
        Intro1.gameObject.SetActive(false);



    }

    void SecondCount()
    {
        Intro3.gameObject.SetActive(true);
        Intro2.gameObject.SetActive(false);
    }

    void FinishIntroduction()
    {
        Intro3.gameObject.SetActive(false);
        IntroIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        EventCamera.SetActive(false);
        Player.SetActive(true);
        //Tunning.SetActive(true);
        GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = true;
        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;
    }
}
