using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class GoblinAttack : MonoBehaviour
{
    public GameObject target;
    public GoblinController gobCon;

    private Animator animator;
    private NavMeshAgent agent;
    public Collider gobRcol;
    public Collider gobLcol;
    

    public float gobAttacTime = 10;
    // Start is called before the first frame update
    void Start()
    {
        gobAttacTime = 10;

        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        gobCon = GetComponent<GoblinController>();

        gobRcol = GameObject.Find("Hand_IK.R").GetComponent<SphereCollider>();
        gobLcol = GameObject.Find("Hand_IK.L").GetComponent<SphereCollider>();
       // Debug.Log("what is "+gobRcol.transform.name);


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
            gobRcol.enabled = true;
          }

       
        if (gobAttacTime < 8f)
        {
            animator.SetBool("attack1",false);
            gobRcol.enabled = false;
        }

        if (gobAttacTime < 6)
        {
            animator.SetBool("attack2", true);
            gobLcol.enabled = true;
        }


        if (gobAttacTime < 5)
        {
            animator.SetBool("attack2", false);
            gobLcol.enabled = false;
        }

        if (gobAttacTime < 3)
        {
            animator.SetBool("power_attack", true);
            gobRcol.enabled = true;
            gobLcol.enabled = true;
        }

      

        if (gobAttacTime < 2)
        {
            animator.SetBool("power_attack", false);
            gobRcol.enabled = false;
            gobLcol.enabled = false;
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
            gobCon.enabled = true;
            agent.enabled = true;
            GetComponent<Rigidbody>().isKinematic = false;
            this.enabled = false;
        }
    }
}
