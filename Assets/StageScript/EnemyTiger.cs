using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyTiger : MonoBehaviour
{
    public GameObject target;

    private int maxHP;
    private int tgHP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 10;
    public int playerKATK = 20;

    private NavMeshAgent agent;
    private Animator animator;
    private AudioSource audioSource;

    public AttackTiger attack;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        attack = GetComponent<AttackTiger>();

    }

    // Update is called once per frame
    void Update()
    {

        animator.SetBool("run", true);
        agent.destination = target.transform.position;

      
    }

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player") 
        {
            animator.SetBool("run",false);
            agent.enabled = false;
            this.enabled = false;
            attack.enabled = true;

        }
    }

}
