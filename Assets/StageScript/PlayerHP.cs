using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//プレイヤーにHPを持たせる
public class PlayerHP : MonoBehaviour
{


    public Text Timer;
    private float countTime;

    private int seconds;

    public Image fill00;
   
    public Transform RevPoint1;
    public Image FadeImage;
    public Text Revtext1;
    public Text TimeOut;
   // public Text TimeOut2;

   
    public int needleATK = 10;
    public int kpgATK = 10;
    public int tgATK = 10;
    public int heartMax = 3;
    public int heartCount = 1;
    public int HP = 100;
    public int poogyeeATK = 10;
    public int repairCount = 100;
    public int trollATK = 20;
    public int btATK = 10;
    public int swATK = 20;
    public int cowPATK = 5;
    public int cowFATK = 5;

    public int cowKATK = 5;
    public int cowFNATK = 5;

    public int gobRATK = 1;
    public int gobLATK = 1;
    public int laserATK = 20;
    public int bomATK = 5;
    public int axeATK = 2;
    public int sdATK = 5;
    public int fFATK = 10;
    public int dkATK = 10;
    public int tbATK = 10;
    public int exFATK = 10;
    public int fallATK = 100;
    public int agATK = 1;

    public GameObject[] heart;

    public int LifeCount = 3;
    public float revTime = 3;
    AudioSource audioSource;
    private Animator animator;

    //クリップ
    public AudioClip Playerdamage;
    public AudioClip Playerdamage2;
    public AudioClip PlayerDeath;
    public AudioClip River;

    public GameObject Player;
    public GameObject FallOut;
    //public GameObject Ceiling;

    public int timePenalty = 100;

    public float outTime = 1;
    // Start is called before the first frame update
    void Start()
    {

        //hPBar = GetComponent<HPBarController>();
        //HPバー取得の為に、HPバーのイメージも取得
        fill00 = GameObject.Find("Fill00").GetComponent<Image>();
        //   heart = GameObject.Find("PlayerLife").GetComponent<Image>();
        fill00.fillAmount = 1;

       // RevPoint1 = new Vector3(-14, 2, -8);
        animator = GetComponent<Animator>();
        audioSource = GetComponent<AudioSource>();
        // FadeImage = GameObject.Find("FadeImage").GetComponent<Image>();
        // FadeImage.color = Color.clear;
        countTime = 300;


    }

    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 200000; i++)
        {
            procount += 1;
        }
        //Updateでタイマーをセットする
        //タイマーの減り方は、カウントタイムーデルタタイム
        //やり方はパイレーツの時と同じ!!
        countTime -= Time.deltaTime;
        seconds = (int)countTime;
        Timer.text = seconds.ToString();

        //もし、時間切れになったら？
        //HPが０になり、ハートが１つ減るようにする
        //その実装はまた今度ゆっくりやろう♡
        if (countTime < 0)
        {
           
            TimeOut.gameObject.SetActive(true);
           // TimeOut2.gameObject.SetActive(true);
            Timer.gameObject.SetActive(false);
            //Ceiling.gameObject.SetActive(true);
            FallOut.gameObject.SetActive(true);
            GetComponent<Rigidbody>().isKinematic = true;

            Invoke("TimeReset",1f);
          
        }



    }

    void TimeReset()
    {
       
        Start();
        TimeOut.gameObject.SetActive(false);
       // TimeOut2.gameObject.SetActive(false);
        Timer.gameObject.SetActive(true);
        FallOut.gameObject.SetActive(false);
        GetComponent<Rigidbody>().isKinematic = false;

    }


    private void OnTriggerEnter(Collider hit)
    {
       // print("ontriggerenter");
//        print("gameobject"+hit.gameObject.name);
        if (hit.gameObject.CompareTag("NeedleAttack"))
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= needleATK;
            fill00.fillAmount -= 0.1f;
            //            audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "EnemyBodyBlow")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= kpgATK;
            fill00.fillAmount -= 0.1f;
            audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "Attack")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= tgATK;
            fill00.fillAmount -= 0.1f;
        }

        if (hit.gameObject.tag == "mace")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= trollATK;
            fill00.fillAmount -= 0.1f;
            Debug.Log(HP);
        }

        if (hit.gameObject.tag == "Bullet")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= btATK;
            fill00.fillAmount -= 0.03f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "Saw")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= btATK;
            fill00.fillAmount -= 0.2f;
        }

        if (hit.gameObject.tag == "laser")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= laserATK;
            fill00.fillAmount -= 0.2f;
        }

        if (hit.gameObject.tag == "BomExploded")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= bomATK;
            fill00.fillAmount -= 0.05f;
        }


        if (hit.gameObject.tag == "RepairItem")
        {

            HP += repairCount;
            fill00.fillAmount += 1f;
        }


        if (hit.gameObject.tag == "HeartItem")
        {

            LifeCount += 1;

//            HeartPlus();
          
        }

        if (hit.gameObject.tag == "CowRPunch")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= cowPATK;
            // audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.05f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "CowLPunch")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= cowFATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.1f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "CowKickR")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= cowPATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.15f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "CowKickL")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= cowPATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.3f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "GobRAttack")
        {
            HP -= gobRATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.01f;
            Debug.Log(gobRATK);
            // audioSource.PlayOneShot(Playerdamage);
        }
        this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");

        if (hit.gameObject.tag == "GobLAttack")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= gobLATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.01f;
            // audioSource.PlayOneShot(Playerdamage);
            Debug.Log(gobLATK);
        }

        if (hit.gameObject.tag == "Axe")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= axeATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.02f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "Sword")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= sdATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.05f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "NeedleBall")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= needleATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.1f;
            // audioSource.PlayOneShot(Playerdamage);
        }


        if (hit.gameObject.tag == "FallFire")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= fFATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.1f;
            // audioSource.PlayOneShot(Playerdamage);
        }


        if (hit.gameObject.tag == "Darkness")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= dkATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.1f;
            // audioSource.PlayOneShot(Playerdamage);
        }


        if (hit.gameObject.tag == "ThunderBall")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= tbATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.1f;
            // audioSource.PlayOneShot(Playerdamage);
        }


        if (hit.gameObject.tag == "ExplosionFlare")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= exFATK;
            //  audioSource.PlayOneShot(Playerdamage);
            fill00.fillAmount -= 0.1f;
            // audioSource.PlayOneShot(Playerdamage);
        }

        if (hit.gameObject.tag == "Water")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= HP;
            fill00.fillAmount -= 1;
           
            FadeImage.gameObject.SetActive(true);
            Revtext1.gameObject.SetActive(true);
            audioSource.PlayOneShot(River);
            Invoke("RevengeWater", 3f);
         

        }


        if (hit.gameObject.tag == "Lava")
        {
            this.gameObject.layer = LayerMask.NameToLayer("PlayerDamage");
            HP -= HP;
            fill00.fillAmount -= 1;

            FadeImage.gameObject.SetActive(true);
            Revtext1.gameObject.SetActive(true);
            audioSource.PlayOneShot(River);
            Invoke("RevengeLava", 3f);
            Debug.Log(HP);

        }

        if (hit.gameObject.tag == "TimeOut")
            
        {
            HP -= HP;
            fill00.fillAmount -= 1;
            Invoke("DestroyCeiling",0.5f);
        }

        //if (hit.gameObject.tag == "Angry")
        //{
        //    HP -= agATK;
        //    fill00.fillAmount -= 0.1f;
        
        //}


        if (HP <= 0)
        {

            LifeCount -= 1;
            fill00.fillAmount += 1;
            HP += 100;

            audioSource.PlayOneShot(Playerdamage2);
            PlayerRetune();
           

            if (LifeCount < 0)
            {
                //print("LifeCount < 0");
                animator.SetTrigger("knockdown_A");
                audioSource.PlayOneShot(PlayerDeath);
                Invoke("Death", 0.5f);
            }

        }


    }

    void PlayerRetune()
    {
        for(int i =0; i < heart.Length; i++)
        {
            if (LifeCount <= i)
            {
                heart[i].SetActive(false);
                //  HP += 100;

            }


        }
    }

    void Revenge()
    {
        animator.ResetTrigger("knockdown_A");
        animator.SetTrigger("getup_A");

        HP += 100;
        fill00.fillAmount = 1;
    }

    void RevengeWater()
    {
        FadeImage.gameObject.SetActive(false);
        Revtext1.gameObject.SetActive(false);

        HP += 100;
        fill00.fillAmount += 1;

        this.transform.position = RevPoint1.transform.position;


    }

    void RevengeLava()
    {
        FadeImage.gameObject.SetActive(false);
        Revtext1.gameObject.SetActive(false);

       HP += 100;
        fill00.fillAmount += 1;
        animator.SetTrigger("getup_A");
        this.transform.position = RevPoint1.transform.position;


    }


    void Death()
    {
        SceneManager.LoadScene("GameOverScene");
    }
}

