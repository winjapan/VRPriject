using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinalStageEvent : MonoBehaviour
{
    public Canvas PlayerCan;
    public Text Intro1;
    public Text Intro2;
    public Text Intro3;
    public Image IntroIm;

    public float introTime;
    public GameObject EventPlayer;
    public GameObject Player;
  
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 17;
        GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = true;
       
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
            ThirdCount();
        }

        if (introTime < 0)
        {
            FinishIntroduction();
        }
    }

    void FirstCount()
    {
        IntroIm.gameObject.SetActive(true);
        PlayerCan.gameObject.SetActive(false);
    }

    void SecondCount()
    {
        Intro2.gameObject.SetActive(true);
        Intro1.gameObject.SetActive(false);
    }

    void ThirdCount()
    {
        Intro3.gameObject.SetActive(true);
        Intro2.gameObject.SetActive(false);
    }

    void FinishIntroduction()
    {
        Intro3.gameObject.SetActive(false);
        IntroIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);
        Player.SetActive(true);
        EventPlayer.SetActive(false);
       
       
      
    }
}
