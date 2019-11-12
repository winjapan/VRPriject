using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinAttackl4 : MonoBehaviour
{
    public GameObject target;
    public GoblinCtrll4 ctrll4;

    private Animator animator;
    private NavMeshAgent agent;
    private Collider gobR4col;
    private Collider gobL4col;
    

    public float gobAttacTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        gobAttacTime = 10;

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        ctrll4 = GetComponent<GoblinCtrll4>();
        gobR4col = GameObject.Find("Hand_IK.R4").GetComponent<SphereCollider>();
        gobL4col = GameObject.Find("Hand_IK.L4").GetComponent<SphereCollider>();
        //  Debug.Log("what is "+gobRcol.transform.name);
        int procount = 0;

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        animator.SetBool("run", false);

        gobAttacTime -= Time.deltaTime;

        if (gobAttacTime < 9) 
        {
            animator.SetBool("attack1",true);
            gobR4col.enabled = true;
          }

       
        if (gobAttacTime < 8.4f)
        {
            animator.SetBool("attack1",false);
            gobR4col.enabled = false;
        }

        if (gobAttacTime < 6)
        {
            animator.SetBool("attack2", true);
            gobL4col.enabled = true;
        }


        if (gobAttacTime < 5)
        {
            animator.SetBool("attack2", false);
            gobL4col.enabled = false;
        }

        if (gobAttacTime < 3)
        {
            animator.SetBool("power_attack", true);
            gobR4col.enabled = true;
            gobL4col.enabled = true;
        }

      

        if (gobAttacTime < 2)
        {
            animator.SetBool("power_attack", false);
            gobR4col.enabled = false;
            gobL4col.enabled = false;
        }

        if (gobAttacTime < 0)
        {
            Start();
        }

    }

    private void OnCollisionExit(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            ctrll4.enabled = true;
            agent.enabled = true;
            GetComponent<Rigidbody>().isKinematic = false;
            this.enabled = false;
        }
    }
}
