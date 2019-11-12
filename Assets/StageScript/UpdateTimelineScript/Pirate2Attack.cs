using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Pirate2Attack : MonoBehaviour
{
    public GameObject target;

    private Animator animator;
    private NavMeshAgent agent;
    public Pirate2Controller pirate2;
    public Collider humCol2;

    public float attackTime = 6;
    // Start is called before the first frame update
    void Start()
    {
        attackTime = 6;
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
        pirate2 = GetComponent<Pirate2Controller>();
        humCol2 = GameObject.Find("Axe Dwarf Berserker2").GetComponent<BoxCollider>();
        //  humCol = GameObject.Find("Weapon_end").GetComponent<BoxCollider>();


    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        //アップデート内の記述について
        // attackTimeから時間を１秒ずつ引く（Time.deltatime）
        //ifで時間を指定する
        //０になったら、スタートから更新
        animator.SetBool("Run", false);
        attackTime -= Time.deltaTime;

        if (attackTime < 6)
        {
            animator.SetBool("Attack1", true);
            humCol2.enabled = true;
        }

        if (attackTime < 5)
        {
            animator.SetBool("Attack1", false);
            humCol2.enabled = false;
        }

        if (attackTime < 3)
        {
            animator.SetBool("Attack4", true);
            humCol2.enabled = true;
        }

        if (attackTime < 2)
        {
            animator.SetBool("Attack4", false);
            humCol2.enabled = false;
        }

        if (attackTime < 0)
        {
            Start();
        }
    }

    private void OnCollisionExit(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            this.enabled = false;
            GetComponent<Rigidbody>().isKinematic = false;
            agent.enabled = true;
            pirate2.enabled = true;
        }
    }
}
