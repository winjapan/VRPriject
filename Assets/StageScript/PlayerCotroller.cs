using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;
using System;

//public struct Sample1
//{

//    public float timeStamp;
//    public float accelY;

//    public Sample1(float stamp,float y)
//    {
//        this.timeStamp = stamp;
//        this.accelY = y;
//    }
//}

public class PlayerCotroller : MonoBehaviour
{
    //public Queue<Sample> PoseSamples { get; } = new Queue<Sample>();
    float prevGestureTime;
    float recognitionInterval = 0.5f;
    Rigidbody rgbody;
    Animator animator;
    public GameObject Player;
    public GameObject InvinciblePlayer;
    public GameObject PunchEffect;
    public GameObject RevavPoint;
    public float walkspeed;
    public GameObject GvrControllerPointer;

    private Collider upperRCol;
    private Collider upperLCol;
    private Collider lowerRLegCol;
    private CharacterController character;
    private float jumppower = 30000;
    //   private float invCountTime =60;
    private AnimatorStateInfo GetInfo;
    public float jumpCount = 0;
    public float Maxjump = 2;
    private float effectPunchSpeed = 2.0f;
    public GameObject KickerEffect;
    public GameObject KingPooGyee;
    public GameObject ArmSwing;
    private float effectPunchHeight = 6000f;
    private float effectPunchWidth = 55f;
    private float effectKickSpeed = 2.0f;
    private float effectKickHeight = 500f;
    private float effectKickWidth = 1f;
    //   private float attackTime = 1f;
    private Vector3 velocity;

    public AudioClip Attack1;
    public AudioClip Attack2;
    public AudioClip Lefthook;
    public AudioClip Damage;

    AudioSource Audio;

    private int seconds;

    public GameObject Turninng;
    public GameObject SwaipManu;
    //    bool jump = false;

    public KingPooGyeeINV gyeeINV;
    public KingPooGyee kingPoo;
    public PowerUpPlayer powerUp;

    private Vector3 playerPos;

    public float PosX;
    public float PosY;
    public float PosZ;

    private float senstivity = 100;

    private float x;
    private float y;
    private float z;

    GvrControllerInputDevice gvrControllerInput;

    public Text NonePlayer;

    public int jumpNum;
    public Text debugText;

    public float fallDown;
    // Start is called before the first frame update
    void Start()
    {
        rgbody = GetComponent<Rigidbody>();
        animator = GetComponent<Animator>();
        Audio = GetComponent<AudioSource>();
        upperRCol = GameObject.Find("upperLeg.R").GetComponent<SphereCollider>();
        upperLCol = GameObject.Find("upperLeg.L").GetComponent<SphereCollider>();
        lowerRLegCol = GameObject.Find("lowerLeg.R").GetComponent<SphereCollider>();
        //  kingPoo = GameObject.Find("KingPooGyee").GetComponent<KingPooGyee>();
        // gyeeINV = GameObject.Find("KingPooGyee").GetComponent<KingPooGyeeINV>();

        rgbody.velocity = Vector3.zero;
        //Physics.gravity = new Vector3(0, -9.8f, 0);

        gvrControllerInput = GvrControllerInput.GetDevice(GvrControllerHand.Dominant);
        jumpCount = 0;
        fallDown = 5000;
    }

    // Update is called once per frame
    public void FixedUpdate()
    {
       // Debug.Log(Physics.gravity);
//        debugText.text = jumpNum.ToString();
        int procount = 0;
        for (int i = 0; i < 200000; i++)
        {
            procount += 1;
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
    //        var averagePitch = PoseSamplesWithin(0.5f, 0.6f).Average(sample => sample.accelY);
    //        var maxPitch = PoseSamplesWithin(0.01f, 0.2f).Max(sample => sample.accelY);
    //        var pitch = PoseSamples.First().accelY;

    //        if (maxPitch - averagePitch < -10f &&
    //            Mathf.Abs(pitch - averagePitch) > -5f)
    //        {
    //            if (prevGestureTime < Time.time - recognitionInterval)
    //            {
    //                prevGestureTime = Time.time;
    //                //StartCoroutine(PlayerJump());
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







    //攻撃パターン設定
    //マウスがクリックされたら、攻撃開始
    //マウスクリックと同時に、アニメーションも実行
    //変更！！
    //連続でZを推した時のした時のプレイヤーの動きをプレイヤーコントローラーで操作する
    //攻撃中は、プレイヤーを移動させないように修正
    //プレハブ化したパーティクルをインスタンス化する(パーティクルは、アセットストアで入手したものを使う)
    //右左にパンチエフェクト、キックは他のものを使用
    //最終的には、X、Cボタンを押したらパンチエフェクト、Zボタンを押したらキックエフェクトが出るようにする
    //(九陰で言うところのキックがセイマ、パンチが太極拳のイメージ)


    void Update()
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

        //RecognizeJump();

        //Debug.LogFormat("<color=red>jumpCount is {0}:</color>", jumpCount);
        //ここでやりたい事はプレイヤーのアニメーションを再生したい
        //動いている時には動いているアニメーション
        //動いているとは右矢印も左矢印も押していない状態
        //止まっている時にはアイドルアニメーション

        float forward = Input.GetAxis("Horizontal");
        rgbody.velocity = new Vector3(forward * walkspeed, 0, 0);

        if (x == 0 && GvrControllerInput.IsTouching && Turninng)
        {
            animator.SetBool("move_forward_B", true);
            //Turninng.gameObject.SetActive(true);
            // Debug.Log("周さんなら、VRも楽勝だね！");
        }
        else
        {
            //  Debug.Log("移動できない周さんは、ただの周さんよ！");
            animator.SetBool("move_forward_B", false);
        }

        if (GvrControllerInput.AppButtonDown && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack")
        && !animator.IsInTransition(0))
        {
            StartCoroutine(RPunch());
            Debug.Log(" 右");
            var Righteffect = Instantiate(PunchEffect, transform.position + Vector3.up * effectPunchSpeed * effectPunchWidth * effectPunchHeight, Quaternion.FromToRotation(Vector3.forward, transform.forward));
        }

        //if (GvrControllerInput.AppButtonUp && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack2") && !animator.IsInTransition(0))
        //{
        //    //StartCoroutine(LPunch());
        //    var Lefteffect = Instantiate(PunchEffect, transform.position + Vector3.up * 0f * effectPunchSpeed * effectPunchWidth * effectPunchHeight, Quaternion.FromToRotation(Vector3.forward, transform.forward));
        //}



        //if (GvrControllerInput.TouchDown && !animator.GetCurrentAnimatorStateInfo(0).IsName("GvrControllerInput.Accel") && !animator.GetCurrentAnimatorStateInfo(0).IsName("Attack3") && !animator.IsInTransition(0))
        //{
        //    StartCoroutine(KickAttack());
        //    var kickEffect = Instantiate(KickerEffect, transform.position + Vector3.up / 150 * effectKickSpeed * effectKickWidth * effectKickHeight, Quaternion.FromToRotation(Vector3.up, transform.up)) as GameObject;
        //}


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

        if (collision.gameObject.tag == "docks")
        {
            jumpCount = 0;

        }



    }


    public void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "InvincibleItem")
        {
            StartCoroutine(PlayerInvincible());
       
        }

        //とったアイテムがパワーアップアイテムだった場合
        //奥義を繰り出せる様にする
        //Z,X,Cはパンチとキックで使っているので、それ以外のキーで対応する
        if (other.gameObject.tag == "PowerItem")
        {
            powerUp.enabled = true;
        }

        if (other.gameObject.tag == "tigerTrap")
        {
            StartCoroutine(Stop());
        }
    }

    IEnumerator RPunch()
    {
        this.gameObject.layer = LayerMask.NameToLayer("RightPunch");

        upperRCol.enabled = true;
        animator.SetBool("Attack", true);
        Audio.PlayOneShot(Attack1);

        yield return new WaitForSeconds(0.2f);
        upperRCol.enabled = false;
        animator.SetBool("Attack", false);
        //Audio.PlayOneShot(Attack1);
        yield return new WaitForSeconds(0.2f);
        this.gameObject.layer = LayerMask.NameToLayer("LeftPunch");

        upperLCol.enabled = true;
        animator.SetBool("Attack2", true);
        Audio.PlayOneShot(Lefthook);

        yield return new WaitForSeconds(0.3f);

        this.gameObject.layer = LayerMask.NameToLayer("Player");
        animator.SetBool("Attack2", false);
        upperLCol.enabled = false;

    }

    //IEnumerator KickAttack()
    //{
    //    this.gameObject.layer = LayerMask.NameToLayer("Kick");

    //    animator.SetBool("Attack3", true);
    //    Audio.PlayOneShot(Attack2);
    //    lowerRLegCol.enabled = true;


    //    yield return new WaitForSeconds(1f);


    //    this.gameObject.layer = LayerMask.NameToLayer("Player");
    //    lowerRLegCol.enabled = false;

    //}
    IEnumerator PlayerInvincible()
    {
        yield return new WaitForSeconds(0.5f);
        Player.gameObject.SetActive(false);
        InvinciblePlayer.gameObject.SetActive(true);
        this.transform.position = InvinciblePlayer.transform.position;
   


        NonePlayer.gameObject.SetActive(true);
        // gyeeINV.enabled = true;
        //  kingPoo.enabled = false;

    }

    IEnumerator Stop()
    {
        walkspeed = 0;

        yield return new WaitForSeconds(1f);

        walkspeed = 30;
    }
}