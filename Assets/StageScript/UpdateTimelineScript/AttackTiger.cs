using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class AttackTiger : MonoBehaviour
{
    public GameObject target;

    private Animator animator;

    private Collider tigerCol;

    private float stayTime;

    private float attackTime;

  
    public AudioClip Cat;
    private AudioSource audioSource;
    private NavMeshAgent agent;

    public float tgTime = 10;

    public EnemyTiger Etiger;
    // Start is called before the first frame update
    void Start()
    {

        animator = GetComponent<Animator>();
        tigerCol = GameObject.Find("head1_RotateToIsolate").GetComponent<SphereCollider>();
        Etiger = GetComponent<EnemyTiger>();
        agent = GetComponent<NavMeshAgent>();

        audioSource = GetComponent<AudioSource>();
        tgTime = 10;
    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        tgTime -= Time.deltaTime;

        if (tgTime < 8)
        {
            animator.SetBool("hit", true);
            tigerCol.enabled = true;
        }

        if(tgTime < 7)
        {
            animator.SetBool("hit", false);
            tigerCol.enabled = false;
        }

        if (tgTime < 4)
        {
            animator.SetBool("sound",true);
            GameObject.Find("TigerSound").GetComponent<AudioSource>().enabled =true;
            GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = true;
        }

        if (tgTime < 2)
        {
            animator.SetBool("sound", false);
            GameObject.Find("TigerSound").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("ma").GetComponent<Rigidbody>().isKinematic = false;
        }

        if (tgTime < 0)
        {
            Start();
        }
    }



   
    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {


            agent.enabled = true;
            this.enabled = false;
            Etiger.enabled = true;
        }
    }

}
