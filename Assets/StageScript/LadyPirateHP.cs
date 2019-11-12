using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LadyPirateHP : MonoBehaviour
{
    public Image GirlFill;

    public int lpHP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 15;
    public int playerKATK = 20;

    public GameObject Warp;
    //public GameObject Treasure;
    public GameObject LadyPirate;

    private Animator animator;

    public GameObject EventDirector;
    public GameObject VRPoint;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        GirlFill = GameObject.Find("GirlFill").GetComponent<Image>();
        lpHP = 300;
        GirlFill.fillAmount = 1;
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


            lpHP -= playerRPATK;
            GirlFill.fillAmount -= 0.044f;

            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {


            lpHP-= playerLPATK;
            GirlFill.fillAmount -= 0.045f;
            GameObject.Find("LadyPirateDamage1").GetComponent<AudioSource>().enabled = true;

            Invoke("StopSE1",0.5f);
        } 


        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

           lpHP -= playerKATK;
            GirlFill.fillAmount -= 0.08f;
            GameObject.Find("LadyPirateAttack2").GetComponent<AudioSource>().enabled = true;
            Invoke("StopSE2", 0.5f);
        }

        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            lpHP -= playerKATK;
            GirlFill.fillAmount -= 0.07f;
           
            Debug.Log("Damage");
        }

        if (lpHP < 0)
        {

            animator.SetTrigger("Damage");
            Invoke("Reset",0.2f);
            GameObject.Find("EventDirector").GetComponent<TimeDirector>().enabled =false;

            GameObject.Find("EventDirector").GetComponent<EventSt4Clear>().enabled =true;

            GameObject.Find("LadyPirateAttack2").GetComponent<AudioSource>().enabled = true;
            Debug.Log(animator);
            this.transform.position = VRPoint.transform.position;
        }

    }

    private void Reset()
    {
        animator.ResetTrigger("Damage");
    }

    void StopSE1()
    {
        GameObject.Find("LadyPirateDamage1").GetComponent<AudioSource>().enabled = false;
    }

    void StopSE2()
    {
        GameObject.Find("LadyPirateDamage2").GetComponent<AudioSource>().enabled = false;
    }
}
