using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class AllayAttack : MonoBehaviour
{
    private Animator animator;
    private Collider sdCol;
    private NavMeshAgent agent;

    public float lpAttackTime = 10;


    public AllayController aCon;
    private Collider aCol;

    public bool One;
    // Start is called before the first frame update
    void Start()
    {
        lpAttackTime = 10;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        aCol = GameObject.Find("Bip001 R Hand A").GetComponent<BoxCollider>();
        One = false;

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        animator.SetBool("walk", false);

        lpAttackTime -= Time.deltaTime;

        if (lpAttackTime < 9)
        {
            animator.SetBool("atk01", true);
            One = true;
            aCol.enabled = true;
            GameObject.Find("LadyPirateAttack1").GetComponent<AudioSource>().enabled = true;
            // gobRcol.enabled = true;
        }

        if (lpAttackTime < 8)
        {
            animator.SetBool("atk01", false);
            One = false;
            aCol.enabled = false;
            //gobRcol.enabled = false;
            GameObject.Find("LadyPirateAttack1").GetComponent<AudioSource>().enabled = false;
        }

        if (lpAttackTime < 6)
        {
            animator.SetBool("atk02", true);
            One = true;
            aCol.enabled = true;
            GameObject.Find("LadyPirateAttack2").GetComponent<AudioSource>().enabled = true;
            //gobRcol.enabled = true;
        }


        if (lpAttackTime < 5)
        {
            animator.SetBool("atk02", false);
            One = false;
            aCol.enabled = false;
            // gobLcol.enabled = false;
            GameObject.Find("LadyPirateAttack2").GetComponent<AudioSource>().enabled = false;
        }

        if (lpAttackTime < 3)
        {
            animator.SetBool("atk03", true);
            One = true;
            aCol.enabled = true;
            // gobRcol.enabled = true;
            //  gobLcol.enabled = true;
            GameObject.Find("LadyPirateAttack3").GetComponent<AudioSource>().enabled = true;
        }



        if (lpAttackTime < 2)
        {
            animator.SetBool("atk03", false);
            One = false;
            aCol.enabled = false;
            //gobRcol.enabled = false;
            //gobLcol.enabled = false;
            GameObject.Find("LadyPirateAttack3").GetComponent<AudioSource>().enabled = false;
        }

        if (lpAttackTime < 0)
        {
            Start();

        }

    }


    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "LastBoss")
        {
            print("OnCollisionExit " + other.gameObject);
            this.enabled = false;
            aCon.enabled = true;
            agent.enabled = true;
            GetComponent<Rigidbody>().isKinematic = false;

        }
    }
}
