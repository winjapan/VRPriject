using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinAttack2 : MonoBehaviour
{


    public GameObject target;
    public GoblinCtrll2 ctrll2;
    private Animator animator;
    private NavMeshAgent agent;
    private Collider gobR2col;
    private Collider gobL2col;


    public float gobAttacTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        gobAttacTime = 10;

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        ctrll2 = GetComponent<GoblinCtrll2>();
        gobR2col = GameObject.Find("Hand_IK.R2").GetComponent<SphereCollider>();
        gobL2col = GameObject.Find("Hand_IK.L2").GetComponent<SphereCollider>();
        //Debug.Log("what is " + gobRcol.transform.name);

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
            animator.SetBool("attack1", true);
            gobR2col.enabled = true;
        }


        if (gobAttacTime < 8f)
        {
            animator.SetBool("attack1", false);
            gobR2col.enabled = false;
        }

        if (gobAttacTime < 6)
        {
            animator.SetBool("attack2", true);
            gobL2col.enabled = true;
        }


        if (gobAttacTime < 5)
        {
            animator.SetBool("attack2", false);
            gobL2col.enabled = false;
        }

        if (gobAttacTime < 3)
        {
            animator.SetBool("power_attack", true);
            gobR2col.enabled = true;
            gobL2col.enabled = true;
        }



        if (gobAttacTime < 2)
        {
            animator.SetBool("power_attack", false);
            gobR2col.enabled = false;
            gobL2col.enabled = false;
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
            ctrll2.enabled = true;
            agent.enabled = true;
            GetComponent<Rigidbody>().isKinematic = false;
            this.enabled = false;
        }
    }
}
