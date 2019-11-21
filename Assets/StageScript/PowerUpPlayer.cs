using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System;

public struct attackSample1
{

    public float timeStamp;
    public float accelY;

    public attackSample1(float stamp, float y)
    {
        this.timeStamp = stamp;
        this.accelY = y;
    }
}
public class PowerUpPlayer : MonoBehaviour
{
    public Queue<attackSample1> PoseSamples { get; } = new Queue<attackSample1>();
    public GameObject DeathEffect;
    public AudioClip DeathAttack;

    public GameObject KickerEffect;
    private float effectKickSpeed = 2.0f;
    private float effectKickHeight = 500f;
    private float effectKickWidth = 1f;

    public AudioClip Attack1;
    public AudioClip Attack2;
    public AudioClip Lefthook;

    private Collider lowerLLegCol;

    private Animator animator;

    private AudioSource audioSource;
    private Rigidbody rgbody;

    private Collider DupperCol;
    float prevGestureTime;
    float recognitionInterval = 0.5f;

    private Vector3 velocity;
    private float senstivity = 100;
    public int effectCount;
    public int effectMax = 1;

    public bool isDeath;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        rgbody = GetComponent<Rigidbody>();
        lowerLLegCol = GameObject.Find("lowerLeg.L").GetComponent<SphereCollider>();

    }


    IEnumerable<attackSample1> PoseSamplesWithin(float startTime, float endTime)
    {
        return PoseSamples.Where(sample =>
            sample.timeStamp < Time.time - startTime &&
            sample.timeStamp >= Time.time - endTime);
    }



    // Update is called once per frame
    void Update()
    {
        if (OnFlipUp())
        {
            DUpper();
        }


    }

    void DUpper()
    {
        try
        {
            var averagePitch = PoseSamplesWithin(0.5f, 0.6f).Average(sample => sample.accelY);
            var maxPitch = PoseSamplesWithin(0.01f, 0.2f).Max(sample => sample.accelY);
            var pitch = PoseSamples.First().accelY;

            if (maxPitch - averagePitch < -10f &&
                Mathf.Abs(pitch - averagePitch) > -5f)
            {
                if (prevGestureTime < Time.time - recognitionInterval)
                {
                    prevGestureTime = Time.time;
                    Death();
                    //Debug.Log("jump");
                }
            }
        }



        catch (InvalidOperationException)
        {
            // PoseSamplesWithin contains no entry

        }
    }

        public float flipTime = 0.5f;

    public bool trigger;

    public bool OnFlipUp()
    {
        Vector3 upConAcc = GvrControllerInput.Accel;

        Debug.Log(GvrControllerInput.Accel);


        trigger = false;

        if (upConAcc.y < 1)//もしコントローラーが０.５秒以内に５センチほど上昇したと判定されたらtriggerにtrueを代入して返す
        {

            rgbody.AddForce(Vector3.up * senstivity * flipTime);
            flipTime -= Time.deltaTime;
            //Debug.Log(flipTime);

            //StartCoroutine(DeathPunch());
            StartCoroutine(KickAttack());

           




            trigger = true;

         
        }

        
        return trigger;
        
    }



        void Death()
        {
           
        }


    IEnumerator KickAttack()
    {

        this.gameObject.layer = LayerMask.NameToLayer("Kick");
        var kickEffect = Instantiate(KickerEffect, transform.position + Vector3.up / 150 * effectKickSpeed * effectKickWidth * effectKickHeight, Quaternion.FromToRotation(Vector3.up, transform.up)) as GameObject;
        isDeath = true;

        animator.SetBool("Attack3", true);
        audioSource.PlayOneShot(Attack2);
        lowerLLegCol.enabled = true;


        yield return new WaitForSeconds(0.3f);
        animator.SetBool("Attack3", false);
        yield return new WaitForSeconds(0.3f);
        animator.SetBool("FinalAttack", true);

        yield return new WaitForSeconds(0.3f);
        isDeath = false;
        animator.SetBool("FinalAttack", false);
        this.gameObject.layer = LayerMask.NameToLayer("Player");
        lowerLLegCol.enabled = false;

    }

        }

