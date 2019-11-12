using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class TigerHP : MonoBehaviour
{
    public int tHP = 100;
    public int playerRPATK = 5;
    public int playerLPATK = 10;
    public int playerKATK = 15;

    public Image tFill;

    AudioSource audioSource;

    private NavMeshAgent agent;
    public AttackTiger tiger;
    public EnemyTiger enemy;
    public GameObject Tiger;
    public AudioClip Cat;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        tiger = GetComponent<AttackTiger>();
        enemy = GetComponent<EnemyTiger>();
        tFill = GameObject.Find("TigerFill").GetComponent<Image>();
        tFill.fillAmount = 1;

        audioSource = GetComponent<AudioSource>();
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

            tHP -= playerRPATK;
            tFill.fillAmount -= 0.05f;
            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }

        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {

            tHP -= playerLPATK;
            tFill.fillAmount -= 0.1f;
            //StatusFill01.fillAmount -= 0.3f;
            //Debug.Log(pgHP -= playerLPATK);


        }

        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            tHP -= playerKATK;
            tFill.fillAmount -= 0.15f;
        }

        if (tHP < 0)
        {
            audioSource.PlayOneShot(Cat);

            Destroy(Tiger);

           // Invoke("End", 0.5f);
        }
    }

}

