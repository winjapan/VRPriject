using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class EventDirector : MonoBehaviour
{
    public float allayTime;
    public Canvas PlayerCan;

    public Text Speak1;
    public Text Speak2;
    public Text Speak3;
    public Text Speak4;
    public Text Speak5;
  
    public Text Thanks;

    // Start is called before the first frame update
    void Start()
    {
        allayTime = 65;

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

        if (allayTime < 60)
        {
            First();
        }

        if (allayTime < 50)
        {
            Second();

        }

        if (allayTime < 40)
        {

           
            Third();
          
        }

        if (allayTime < 30)
        {
            Forth();
        }

        if (allayTime < 20)
        {
            Fifth();
        }
        if (allayTime < 10)
        {
            Thankyou();
        }


        if (allayTime < 0)
        {
            allayTime = 0;
            SceneManager.LoadScene("StartSceene");

        }
        void First()
        {
            Speak1.gameObject.SetActive(true);
        }

        void Second()
        {
            Speak1.gameObject.SetActive(false);
            Speak2.gameObject.SetActive(true);
        }

        void Third()
        {
            Speak2.gameObject.SetActive(false);
            Speak3.gameObject.SetActive(true);
        }
        void Forth()
        {
            Speak3.gameObject.SetActive(false);
            Speak4.gameObject.SetActive(true);
        }

        void Fifth()
        {
            Speak4.gameObject.SetActive(false);
            Speak5.gameObject.SetActive(true);
        }

        void Thankyou()
        {
            Speak5.gameObject.SetActive(false);
            Thanks.gameObject.SetActive(true);
        }
    }
}