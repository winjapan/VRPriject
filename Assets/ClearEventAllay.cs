using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ClearEventAllay : MonoBehaviour
{
    public float allayTime;
    public Canvas PlayerCan;

    public Text Speak1;
    public Text Speak2;
    public Text Speak3;
    public Text Speak4;
    public Text Speak5;
    public Text Speak6;

    public Image ClearIm;
    public Image playerIm;

    public Text pSpeak1;
    public Text pSpeak2;
    public Text pSpeak3;
    public Text pSpeak4;
    public Text pSpeak5;

    public GameObject Box;
    public GameObject unity;
    public GameObject Allay;
    public GameObject Player3;
    public GameObject EventPlayer4;
    public GameObject Player5;

    public AudioSource ive;
    // Start is called before the first frame update
    void Start()
    {
        allayTime = 60;

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        allayTime -= Time.deltaTime;

        if (allayTime < 59)
        {
            ive.enabled = false;
        }

        if (allayTime < 56)
        {
            Player3.SetActive(false);
            EventPlayer4.SetActive(true);

        }

        if (allayTime < 55)
        {
            ClearIm.gameObject.SetActive(true);
            GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = true;
        }

        if (allayTime < 50)
        {
            ClearIm.gameObject.SetActive(false);
            Speak1.gameObject.SetActive(false);
            Speak2.gameObject.SetActive(true);

            playerIm.gameObject.SetActive(true);
        }

        if (allayTime <45)
        {
            ClearIm.gameObject.SetActive(true);

            playerIm.gameObject.SetActive(false);
            pSpeak1.gameObject.SetActive(false);
            pSpeak2.gameObject.SetActive(true);
        }

        if (allayTime <40)
        {
            ClearIm.gameObject.SetActive(false);
            Speak2.gameObject.SetActive(false);
            Speak3.gameObject.SetActive(true);

            playerIm.gameObject.SetActive(true);
           
        }
        if (allayTime <35)
        {
            pSpeak2.gameObject.SetActive(false);
            pSpeak3.gameObject.SetActive(true);
        }

        if (allayTime < 30)
        {
            ClearIm.gameObject.SetActive(true);
            playerIm.gameObject.SetActive(false);
            pSpeak3.gameObject.SetActive(false);
            pSpeak4.gameObject.SetActive(true);
        }

        if (allayTime < 25)
        {

            ClearIm.gameObject.SetActive(false);
            Speak3.gameObject.SetActive(false);
            Speak4.gameObject.SetActive(true);

            playerIm.gameObject.SetActive(true);

        }

        if (allayTime < 20)
        {
            pSpeak4.gameObject.SetActive(false);
            pSpeak5.gameObject.SetActive(true);
        }

        if (allayTime < 15)
        {
            ClearIm.gameObject.SetActive(true);


            playerIm.gameObject.SetActive(false);

        }

        if (allayTime < 10)
        {
            Speak4.gameObject.SetActive(false);
            Speak5.gameObject.SetActive(true);
        }

        if (allayTime <5)
        {
            Speak5.gameObject.SetActive(false);
            Speak6.gameObject.SetActive(true);
           
        }

        if (allayTime < 0)
        {
            allayTime = 0;
            Player5.SetActive(true);
            EventPlayer4.SetActive(false);
            ClearIm.gameObject.SetActive(false);
            Box.SetActive(false);
            unity.SetActive(true);
            Allay.SetActive(false);
        }
    }
}
