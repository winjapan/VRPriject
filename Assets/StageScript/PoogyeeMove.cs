using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

//プーギーを動かすスクリプト
public class PoogyeeMove : MonoBehaviour
{

    public bool isActive = false;

    [SerializeField]
    public Transform[] destpoints;
    public Transform target;
    public AudioClip PoogyeeVoice;
    public AudioClip PoogyeeCryVoice;

    private float walkSpeed = 1.5f;
    private float runSpeed = 5f;
    private int destpoint = 0;
    private Vector3 targetPosition;


    public Vector3 targetPos;
    private Rigidbody rgbody;
    private AudioSource source;



    //アニメーターとナビを動かす準備
    private Animator animator;
    private NavMeshAgent agent;

    public int maxHP = 100;
    public int pgHP = 100;
    public int playerRPATK = 10;

    public int playerLPATK = 10;
    public int playerKATK = 10;

    public Image StatusFill01;
    public GameObject Poogyee;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();

       
        agent.updateRotation = true;
        agent.updatePosition = true;


        //hPBar = GetComponent<HPBarController>();
        //HPバー取得の為に、HPバーのイメージも取得
       

        StatusFill01 = GameObject.Find("Status Fill 01").GetComponent<Image>();
        StatusFill01.fillAmount = 1;
    }

    private void OnCollisionStay(Collision col)
    {
        if (col.gameObject.tag == "Player")
        {
            agent.enabled = true;
            animator.SetBool("New State 1",true);
        }
    }

    // Update is called once per frame
    private void Update()
    {

    }



    private void OnTriggerEnter(Collider hit)
    {
        //右パンチダメージ
        if (hit.gameObject.tag == "RPunch")
        {
            StartCoroutine(RPDamage());

            pgHP -= playerRPATK;
            StatusFill01.fillAmount -= 0.1f;

        }

        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {
            StartCoroutine(LPDamage());
            pgHP -= playerLPATK;
            StatusFill01.fillAmount -= 0.3f;
      


        }

        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {
            StartCoroutine(KDamage());
            pgHP -= playerKATK;
            StatusFill01.fillAmount -= 0.4f;
       
            }
            //プーギーのHPが０になったら
            //プーギーを消滅させる
            //０以下からは、HPを変動させない
            if (pgHP <= 0)
            {
                Destroy(gameObject);
              
            }

        }

    IEnumerator RPDamage()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("New State 0", false);
        agent.autoBraking = false;

        yield return new WaitForSeconds(1f);
        animator.SetBool("New State 0", true);
        agent.autoBraking = true;
    }

    IEnumerator LPDamage()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("New State 0", false);
        agent.autoBraking = false;

        yield return new WaitForSeconds(1f);
        animator.SetBool("New State 0", true);
        agent.autoBraking = true;
    }

    IEnumerator KDamage()
    {
        yield return new WaitForSeconds(0.1f);
        animator.SetBool("New State 0", false);
        agent.autoBraking = false;

        yield return new WaitForSeconds(1f);
        animator.SetBool("New State 0", true);
        agent.autoBraking = true;
    }

    public void OnTriggerStay(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PoogyeeAttack");

        }
    }
    public void OnTriggerExit(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            this.gameObject.layer = LayerMask.NameToLayer("Poogyee");
            animator.SetBool("New State 1", false);
           // GoToNextPoint();
        }
    }


}

