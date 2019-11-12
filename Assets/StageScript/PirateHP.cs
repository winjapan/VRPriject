using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PirateHP : MonoBehaviour
{
    public int ptHP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 10;
    public int playerKATK = 20;

    private Animator animator;

    public Image pirateFill;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
       pirateFill = GameObject.Find("PirateFill").GetComponent<Image>();
        ptHP = 100;
        pirateFill.fillAmount = 1;
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


            ptHP -= playerRPATK;
            pirateFill.fillAmount -= 0.1f;

            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {


            ptHP -= playerLPATK;
            pirateFill.fillAmount -= 0.15f;

            Debug.Log("Damage");


        }


        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {
            ptHP -= playerKATK;
            pirateFill.fillAmount -= 0.20f;

            Debug.Log("Damage");
        }

        if (hit.gameObject.tag == "LKick")
        {
            ptHP -= playerKATK;
            pirateFill.fillAmount -= 0.20f;

            Debug.Log("Damage");
        }

        if (ptHP < 1)
        {
            animator.SetTrigger("Death2");
            Invoke("Death", 1f);
        }
    }

    void Death()
    {
        Destroy(gameObject, 1f);
    }
}
