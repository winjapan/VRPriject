using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class Epilog : MonoBehaviour
{
    public Text Clear1;
    public Text Clear2;
    public Text Clear3;
    public Text Clear4;
    public Text Final;
    public Text Say;
    public Button Retune;

    public float ClearTime =20;

    // Start is called before the first frame update
    void Start()
    {
        ClearTime = 20;

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        ClearTime -= Time.deltaTime;
         
        if (ClearTime < 19)
        {
            Clear1.gameObject.SetActive(true);
          
        }

        if (ClearTime < 16)
        {
            Clear1.gameObject.SetActive(false);

        }

        if (ClearTime < 14)
        {
            Clear2.gameObject.SetActive(true);

        }

        if (ClearTime < 11)
        {
            Clear2.gameObject.SetActive(false);

        }

        if (ClearTime < 9)
        {
            Clear3.gameObject.SetActive(true);

        }

        if (ClearTime < 6)
        {
            Clear3.gameObject.SetActive(false);

        }

        if (ClearTime < 4)
        {
            Clear4.gameObject.SetActive(true);

        }

        if (ClearTime < 1)
        {
            Clear4.gameObject.SetActive(false);

        }

        if (ClearTime < 0)
        {
            Final.gameObject.SetActive(true);
            Retune.gameObject.SetActive(true);
            Say.gameObject.SetActive(true);
        }

      
    }
}
