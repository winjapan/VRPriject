using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeekerPirateHP : MonoBehaviour
{
    public Image spFill;

    public int spHP = 100;
    public int playerRPATK = 25;
    public int playerLPATK = 25;
    public int playerKATK = 40;



    // Start is called before the first frame update
    void Start()
    {
       spFill = GameObject.Find("SPFill").GetComponent<Image>();
        spHP = 100;
        spFill.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        //右パンチダメージ
        if (hit.gameObject.tag == "RPunch")
        {


            spHP -= playerRPATK;
            spFill.fillAmount -= 0.25f;

            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {


            spHP -= playerLPATK;
            spFill.fillAmount -= 0.25f;

            Debug.Log("Damage");


        }


        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            spHP -= playerKATK;
            spFill.fillAmount -= 0.40f;

            Debug.Log("Damage");
        }

        if (spHP < 0)
        {

            Destroy(gameObject);
        }

    }

}
