using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinAttack3 : MonoBehaviour
{
    public GameObject target;
    public GoblinCtrll3 gob3;

    private Animator animator;
    private NavMeshAgent agent;
    private Collider gobR3col;
    private Collider gobL3col;


    public float gobAttacTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        gobAttacTime = 10;

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        gob3 = GetComponent<GoblinCtrll3>();
        gobR3col = GameObject.Find("Hand_IK.R3").GetComponent<SphereCollider>();
        gobL3col = GameObject.Find("Hand_IK.L3").GetComponent<SphereCollider>();
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
            animator.SetBool("attack1", true);
            gobR3col.enabled = true;
        }


        if (gobAttacTime < 8.4f)
        {
            animator.SetBool("attack1", false);
            gobR3col.enabled = false;
        }

        if (gobAttacTime < 6)
        {
            animator.SetBool("attack2", true);
            gobL3col.enabled = true;
        }


        if (gobAttacTime < 5)
        {
            animator.SetBool("attack2", false);
            gobL3col.enabled = false;
        }

        if (gobAttacTime < 3)
        {
            animator.SetBool("power_attack", true);
            gobR3col.enabled = true;
            gobL3col.enabled = true;
        }



        if (gobAttacTime < 2)
        {
            animator.SetBool("power_attack", false);
            gobR3col.enabled = false;
            gobL3col.enabled = false;
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
            gob3.enabled = true;
            agent.enabled = true;
            GetComponent<Rigidbody>().isKinematic = false;
            this.enabled = false;
        }
    }
}
