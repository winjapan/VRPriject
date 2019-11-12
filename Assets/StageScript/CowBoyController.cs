using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class CowBoyController : MonoBehaviour
{
    //ゲームオブジェクト
    public GameObject target;

    //オーディオクリップ

        //コンポーネント
    private Rigidbody rgbody;
    private AudioSource audioSource;
    private Animator animator;
    private NavMeshAgent agent;

    public BossAttack boss;

    //代入変数
//    private int bpSpeed = 5;

   


    public Image sk2Fill;
    // Start is called before the first frame update
    void Start()
    {

        rgbody = GetComponent<Rigidbody>();
        audioSource = GetComponent<AudioSource>();
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();
        boss = GetComponent<BossAttack>();
    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        agent.destination = target.transform.position;
        animator.SetBool("move", true);
    }

    private void OnCollisionStay(Collision other)
    {
        if (other.gameObject.tag == "Player")
        {
            animator.SetBool("move",false);
            agent.enabled = false;

            this.enabled = false;
            boss.enabled = true;
        }
    }

}
