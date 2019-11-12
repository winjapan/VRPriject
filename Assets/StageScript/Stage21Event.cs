using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage21Event : MonoBehaviour
{
    public Canvas PlayerCan;
    public Text Intro1;
    public Text Intro2;
    public Text Intro3;
    //public Text IntroEx;
    public Image IntroIm;
    //public GameObject Tiger;
    public GameObject Tunning;

    public float introTime;
    public GameObject EventPlayer;
    public GameObject Player;
    // Start is called before the first frame update
    void Awake()
    {
        introTime = 20;
      
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
            SecondCount();

        }

        if (introTime < 10)
        {
            ThardCount();
        }

        if (introTime < 5)
        {
            ForthCount();
        }

        if (introTime < 0)
        {
            EndEvent();
        }
    }

    void SecondCount()
    {
        IntroIm.gameObject.SetActive(true);
        Intro1.gameObject.SetActive(true);
        //IntroEx.gameObject.SetActive(false);
        Tunning.SetActive(false);
    }

    void ThardCount()
    {
        Intro2.gameObject.SetActive(true);
        Intro1.gameObject.SetActive(false);

    }

    void ForthCount()
    {
        Intro3.gameObject.SetActive(true);
        Intro2.gameObject.SetActive(false);
    }

    void EndEvent()
    {
        IntroIm.gameObject.SetActive(false);
        PlayerCan.gameObject.SetActive(true);

        GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = false;
        GameObject.Find("ma").GetComponent<PlayerCotroller>().enabled = true;
        GameObject.Find("ma").GetComponent<PlayerHP>().enabled = true;
        //Tiger.SetActive(true);
        Tunning.SetActive(true);
        Player.SetActive(true);
        EventPlayer.SetActive(false);
        Destroy(this.gameObject);
    }
}
