﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;

public class KingPooGyeeINV : MonoBehaviour
{
    public GameObject KingPoogyee;
    public GameObject target;
    public GameObject GoldenMagicDragonOrb;

    //キングプーギーの歩行スピード
    private int pgwarkSpeed = 2;
    private int pgAttackSpeed = 5;
    private float kpgfreezTime = 0.8f;
    private float kpgfreezCount = 0;
    private KingPooGyee kingPoo;
    private KingPooGyeeINV gyeeINV;
    //HP
   
    private NavMeshAgent agent;
    private Animator animator;

    private Collider pgCol;

    // Start is called before the first frame update
    //Update内でのキンプー攻撃修正
    //カウボーイコントローラー、レディパイレーツコントローラーとやり方は一緒
    //時間はキンプータイムから設定
    //10秒よりも少し多めに取って、１５秒で設定
    public float kpTime = 15;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        animator = GetComponent<Animator>();


        agent.updateRotation = true;
        agent.updatePosition = true;
        pgCol = GameObject.Find("Bip001").GetComponent<SphereCollider>();

        kpTime = 15;
    }


    // Update is called once per frame
    void Update()
    {

        kpTime -= Time.deltaTime;

        if (kpTime < 15)
        {

            animator.SetBool("New State 0", true);
            agent.destination = target.transform.position;
            pgCol.enabled = false;

            agent.updateRotation = true;
            agent.updatePosition = true;
        }

        if (kpTime < 10)
        {
            animator.SetBool("New State 0", false);



            agent.destination = this.transform.position;
            pgCol.enabled = false;


            agent.updateRotation = false;
            agent.updatePosition = false;

        }

        if (kpTime < 7)
        {

            animator.SetBool("New State 1", true);


            agent.destination = target.transform.position;
            pgCol.enabled = true;

            agent.updateRotation = true;
            agent.updatePosition = true;
        }

        if (kpTime < 3)
        {
            animator.SetBool("New State 1", false);
            agent.destination = this.transform.position;
            pgCol.enabled = false;


            agent.updateRotation = false;
            agent.updatePosition = false;
        }

        if (kpTime < 0)
        {
            Start();
        }

    }




}