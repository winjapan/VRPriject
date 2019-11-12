using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

//public struct Sample
//{

//    public float timeStamp;
//    public float accelY;

//    public Sample(float stamp, float y)
//    {
//        this.timeStamp = stamp;
//        this.accelY = y;
//    }
//}

public class IVCPlayerController : MonoBehaviour
{

    //public Queue<Sample> PoseSamples { get; } = new Queue<Sample>();
    float prevGestureTime;
    float recognitionInterval = 0.5f;

    public Text NonePlayer;

    Rigidbody rgbody;
    Animator animator;
    public GameObject Player;
    public GameObject InvinciblePlayer;
    public GameObject AMundarinDuckEffect;
    public GameObject ArmSwing;
    public GameObject GvrControllerPointer;

    public float walkspeed;

    private Collider swordRCol;
    private Collider swordLCol;

    private float jumppower = 30000;

    public float jumpCount = 0;
    public float Maxjump = 2;

    private Vector3 velocity;
    private float effectSwordSpeed = 2.0f;
    private float effectswordHeight = 1000f;
    private float effectswordWidth = 1000f;

    public AudioClip AMandarinduck;

    public AudioClip IVC;
    public AudioClip IVCAttack;

    // public AudioClip Lefthook;
    AudioSource Audio;
    public KingPooGyeeINV gyeeINV;
    public KingPooGyee kingPoo;

    public GameObject Turninng;

    GvrControllerInputDevice gvrControllerInput;
    private float senstivity = 100;

    private float x;
    private float y;
    private float z;


    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();

        swordRCol = GameObject.Find("RightSword").GetComponent<BoxCollider>();
        swordLCol = GameObject.Find("LeftSword").GetComponent<BoxCollider>();

        rgbody.velocity = Vector3.zero;
        Audio.PlayOneShot(IVC);
        gvrControllerInput = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
        Invoke("RetunePlayer",15f);
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
    }


    // Update is called once per frame
    void FixedUpdate()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        //PoseSamples.Enqueue(new Sample(Time.time, gvrControllerInput.Accel.y));
        //if (PoseSamples.Count >= 520)
        //{
        //    PoseSamples.Dequeue();
        //}

       

        //Debug.LogFormat("<color=red>jumpCount is {0}:</color>", jumpCount);
        //ここでやりたい事はプレイヤーのアニメーションを再生したい
        //動いている時には動いているアニメーション
        //動いているとは右矢印も左矢印も押していない状態
        //止まっている時にはアイドルアニメーション

        float forward = Input.GetAxis("Horizontal");
        rgbody.velocity = new Vector3(forward * walkspeed, 0, 0);

        if (x == 0 && GvrControllerInput.IsTouching && Turninng)
        {
            animator.SetBool("Run", true);
            //Turninng.gameObject.SetActive(true);
            // Debug.Log("周さんなら、VRも楽勝だね！");
        }
        else
        {
            //  Debug.Log("移動できない周さんは、ただの周さんよ！");
            animator.SetBool("Run",false);
        }
        //プレイヤーのジャンプについて
        //スペースキーが押されたらY軸に移動
        //ある程度上がったら、重力（リジットボディー）の力で落下
        //さらに、２段ジャンプも追加

        //if (OnFlipUp())
        //{
        //    PlayerJump();
        //}

    }

    //IEnumerable<Sample> PoseSamplesWithin(float startTime, float endTime)
    //{
    //    return PoseSamples.Where(sample =>
    //        sample.timeStamp < Time.time - startTime &&
    //        sample.timeStamp >= Time.time - endTime);
    //}

    //void RecognizeJump()
    //{
    //    try
    //    {
    //        var averagePitch = PoseSamplesWithin(0.2f, 0.4f).Average(sample => sample.accelY);
    //        var maxPitch = PoseSamplesWithin(0.01f, 0.2f).Max(sample => sample.accelY);
    //        var pitch = PoseSamples.First().accelY;

    //        if (maxPitch - averagePitch < -10f &&
    //            Mathf.Abs(pitch - averagePitch) > -5f)
    //        {
    //            if (prevGestureTime < Time.time - recognitionInterval)
    //            {
    //                prevGestureTime = Time.time;
    //                PlayerJump();
    //                //Debug.Log("jump");
    //            }
    //        }
    //    }
    //    catch (InvalidOperationException)
    //    {
    //        // PoseSamplesWithin contains no entry
    //    }
    //}


    //public float flipTime = 0.5f;

    //public bool trigger;
    //private float jumpSpeed;

    //public bool OnFlipUp()
    //{
    //    Vector3 upConAcc = GvrControllerInput.Accel;

    //    //Debug.Log(GvrControllerInput.Accel);


    //    trigger = false;

    //    if (upConAcc.y < 5 && jumpCount < Maxjump)//もしコントローラーが０.５秒以内に５センチほど上昇したと判定されたらtriggerにtrueを代入して返す
    //    {

    //        rgbody.AddForce(Vector3.up * senstivity * flipTime);
    //        flipTime -= Time.deltaTime;
    //        //Debug.Log(flipTime);


    //        trigger = true;


    //    }

    //    return trigger;
    //}

    //private void PlayerJump()
    //{

    //    rgbody.AddForce(Vector3.up * jumppower + transform.forward * walkspeed);
    //    //jumpCount += 1;
    //    Physics.gravity = new Vector3(0, -2000, 0);
    //}




void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        if (GvrControllerInput.AppButtonDown)
        {
            StartCoroutine(SwordAttack());
            Audio.PlayOneShot(IVCAttack);
            var SwordEffect  = Instantiate(AMundarinDuckEffect, transform.position + Vector3.forward * 0f * effectSwordSpeed * effectswordWidth * effectswordHeight, Quaternion.FromToRotation(Vector3.forward, transform.forward));

            Destroy(SwordEffect,1f);
        }

   
    }

   IEnumerator SwordAttack()
    {
        animator.SetBool("Attack1", true);
        swordRCol.enabled = true;
        swordLCol.enabled = true;

        yield return new WaitForSeconds(1f);

        animator.SetBool("Attack1",false);
        swordRCol.enabled = false;
        swordLCol.enabled = false;
    }

    public void Hit()
    {

    }


    void OnCollisionEnter(Collision collision)
    {
        //連続ジャンプができるように、タグで床オブジェを指定する（ジャンプカウントが０）
        //ステージ２の洞窟も同じ様に設定
        //ステージ４のビーチ（テラン）も同様にタグ設定で指定
        if (collision.gameObject.tag == "Bridge")
        {
            jumpCount = 0;

        }

        if (collision.gameObject.tag == "Plane")
        {
            jumpCount = 0;
        }

        if (collision.gameObject.tag == "Terran")
        {
            jumpCount = 0;
        }

        if (collision.gameObject.tag == "Beach")
        {
            jumpCount = 0;

        }


    }

    void RetunePlayer()
    {
        Player.gameObject.SetActive(true);
        InvinciblePlayer.gameObject.SetActive(false);
        //GameObject.Find("BossBGM").GetComponent<AudioSource>().enabled = true;

        this.transform.position = Player.transform.position;
        NonePlayer.gameObject.SetActive(false);
    }

}




