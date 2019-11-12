using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WizardAttack : MonoBehaviour
{
    public GameObject ExEffect;
    public GameObject Magic;

    public GameObject Fires;
    public GameObject Fires2;
    public GameObject Fires3;
    public GameObject Fires4;

    public GameObject Lasers;
    public GameObject Lasers2;
    public GameObject Lasers3;
    public GameObject Lasers4;



    private Animator animator;
    private Collider bCol;

    public float attackTime = 10;
    public int effectCount = 0;
    public int effectMax = 1;
    public int exCounnt = 0;
    public int ecMax = 1;

    public float effectPosX = -50;

    bool One = false;
    // Start is called before the first frame update
    void Start()
    {
        attackTime = 25;
      effectCount = 0;
         exCounnt = 0;

    animator = GetComponent<Animator>();
        bCol = GameObject.Find("Mesh_Body").GetComponent<SphereCollider>();
       
    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        attackTime -= Time.deltaTime;

        if (attackTime < 23)
        {
            animator.SetBool("attack_short_001", true);


            Magic.SetActive(true);

               
        }

        if (attackTime < 21)
        {
            animator.SetBool("attack_short_001", false);
            Magic.SetActive(false);
        }

        if (attackTime < 19)
        {
            animator.SetBool("attack_short_001", true);
            Fires.gameObject.SetActive(true);
            Fires2.gameObject.SetActive(true);
            Fires3.gameObject.SetActive(true);
            Fires4.gameObject.SetActive(true);

        }

        if (attackTime < 15)
        {
            animator.SetBool("attack_short_001", false);
            Fires.gameObject.SetActive(false);
            Fires2.gameObject.SetActive(false);
            Fires3.gameObject.SetActive(false);
            Fires4.gameObject.SetActive(false);
        }

        if (attackTime < 13)
        {
            animator.SetBool("attack_short_001", true);

            Lasers.gameObject.SetActive(true);
            Lasers2.gameObject.SetActive(true);
            Lasers3.gameObject.SetActive(true);
            Lasers4.gameObject.SetActive(true);
            bCol.enabled = false;
        }

        if (attackTime < 8)
        {
            animator.SetBool("attack_short_001", false);
            Lasers.gameObject.SetActive(false);
            Lasers2.gameObject.SetActive(false);
            Lasers3.gameObject.SetActive(false);
            Lasers4.gameObject.SetActive(false);

        }

        if (attackTime < 6)
        {
            bCol.enabled = true;
        }

        if (attackTime < 5)
        {
            animator.SetBool("attack_short_001", true);

            ExEffect.SetActive(true);
            bCol.enabled = false;
        }

        if (attackTime < 2f) 
        {
            animator.SetBool("attack_short_001", false);
            ExEffect.SetActive(false);
          
        }

        if (attackTime <1)
        {
            bCol.enabled = true;
        }

        if (attackTime < 0)
        {
            Start();
        }
    }
    }

