using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class WizardHP : MonoBehaviour
{
    public Image LastBossFill;
    public Canvas Last;
    public GameObject unitychan;
    public GameObject Prison;
    public GameObject EnemyAttack;
    public GameObject Bridge;
    public GameObject BossBGM;
    public int wzHP;
    public int playerRPATK = 10;
    public int playerLPATK = 10;
    public int playerIVCATK = 20;
    private Animator animator;
    public GameObject ClearPoint;
    public GameObject AllayPoint;
    public GameObject Wall;
    public AudioSource playerSouce;
    public AudioSource IvcSouce;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        LastBossFill = GameObject.Find("LastBossFill").GetComponent<Image>();
        wzHP = 500;
        LastBossFill.fillAmount = 1;
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


            wzHP -= playerRPATK;
            LastBossFill.fillAmount -= 0.03f;

            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ

            wzHP -= playerLPATK;
        if (hit.gameObject.tag == "LPunch")
        {

            LastBossFill.fillAmount -= 0.03f;

            Debug.Log("Damage");


        }


        if (hit.gameObject.tag == "IVCSword")
        {

            wzHP -= playerIVCATK;
            LastBossFill.fillAmount -= 0.06f;
            animator.SetTrigger("damage_001 0");


        }
        else
        {
            animator.ResetTrigger("damage_001 0");
        }

        if (wzHP < 0)
        {
            animator.SetTrigger("dead");

          
            Invoke("Death", 0.2f);
        }

    }

    void Death()
    {
        this.gameObject.SetActive(false);
        EnemyAttack.gameObject.SetActive(false);
        Last.gameObject.SetActive(false);
 
        playerSouce.enabled = false;
        IvcSouce.enabled = false;

        GameObject.Find("Lady Pirate Ally").GetComponent<NavMeshAgent>().enabled = true;
        GameObject.Find("Lady Pirate Ally").GetComponent<ClearPointMove>().enabled = true;
        ClearPoint.gameObject.SetActive(true);
        AllayPoint.SetActive(false);
        Wall.SetActive(false);
        Bridge.SetActive(false);
       
}
}
