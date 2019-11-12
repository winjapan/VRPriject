using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
public class CowBoyHP : MonoBehaviour
{

    public AudioClip Damage1;
    public AudioClip Damage2;
    public AudioClip Damage3;
    public AudioClip Damage4;
    public AudioClip Damage5;

    public int CowHP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 15;
    public int playerKATK = 20;
    public int playerDBATK = 30;
    public int tornadoATK = 10;
    public Image CowFill;

    private AudioSource audioSource;
    private Animator animator;

    public float animaTime;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        animator = GetComponent<Animator>();
        CowFill = GameObject.Find("Status Fill 00").GetComponent<Image>();
        CowHP = 300;
        CowFill.fillAmount = 1;
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
            audioSource.PlayOneShot(Damage1);
            animator.SetTrigger("Damage");
            CowHP -= playerRPATK;
            CowFill.fillAmount -= 0.045f;
           
            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }
        else
        {
            animator.ResetTrigger("Damage");
        }

        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {
            animator.SetTrigger("Damage");
            audioSource.PlayOneShot(Damage2);
            CowHP -= playerLPATK;
            CowFill.fillAmount -= 0.04f;

            Debug.Log("Damage");


        }
        else
        {
            animator.ResetTrigger("Damage");
        }


        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {
            audioSource.PlayOneShot(Damage3);
            CowHP -= playerKATK;
            CowFill.fillAmount -= 0.07f;
            animator.SetTrigger("Damage");
            Debug.Log("Damage");
        }
        else
        {
            animator.ResetTrigger("Damage");
        }



        if (hit.gameObject.tag == "LKick")
        {

            Invoke("EndDamage", 1f);
            CowHP -= playerKATK;
            CowFill.fillAmount -= 0.07f;
            //Debug.Log(pgHP -= playerKATK);
        }

        if (CowHP < 0)
        {
            animator.SetTrigger("KnockDown");
            this.enabled = false;
            
         
            audioSource.PlayOneShot(Damage5);
            GameObject.Find("Cowboy").GetComponent<BossAttack>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled =false;
            GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = true;

            GameObject.Find("GameDirector").GetComponent<St3BossClearEvent>().enabled = true;
        }
    }

}
