using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SeekerPirateAttack : MonoBehaviour
{
    public SeekerPirateController spCon;
    private NavMeshAgent agent;
    private Animator animator;
    public Collider axeCol;

    public float spAttackTime = 5;
    // Start is called before the first frame update
    void Start()
    {
        spAttackTime = 5;
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        spCon = GetComponent<SeekerPirateController>();
      //  axeCol = GameObject.Find("NPC_Tools_Axe_004").GetComponent<BoxCollider>();
    }

    // Update is called once per frame
    void Update()
    {
        animator.SetBool("Walk",false);
        spAttackTime -= Time.deltaTime;

        if (spAttackTime < 4)
        {
            animator.SetBool("Attack",true);
            axeCol.enabled = true;
        }

        if (spAttackTime < 3.4)
        {
            animator.SetBool("Attack", false);
            axeCol.enabled = false;
        }

        if (spAttackTime < 0) 
        {
            Start();
          }
    }

    private void OnCollisionEnd(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.enabled = false;
            spCon.enabled = true;
            agent.enabled = true;
            GetComponent<Rigidbody>().isKinematic = false;
        }
    }
}
