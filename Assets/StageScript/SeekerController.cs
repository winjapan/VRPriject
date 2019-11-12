using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class SeekerController : MonoBehaviour
{

    private AudioSource audioSource;
    private Rigidbody rgbody;
    //    private int bulletPosX = -100;

    public int waitFreezetime = 200;
    private Animator animator;
    public int waitFreezeCount = 0;
    public int attackCount = 0;
    //  int bulletCount = 1;

    public GenelateBullet bullet;

    public int skHP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 15;
    public int playerKATK = 20;
    public int playerDBATK = 30;
    public int tornadoATK = 10;


    public Image skFill;

    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        skFill = GameObject.Find("Status Fill 01").GetComponent<Image>();
        skFill.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        StartCoroutine(Wait());
        StartCoroutine(Shot());
    }

    private void OnTriggerEnter(Collider hit)
    {

        //右パンチダメージ
        if (hit.gameObject.tag == "RPunch")
        {

            skHP -= playerRPATK;
            skFill.fillAmount -= 0.09f;
            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }

        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {

            skHP -= playerLPATK;
            skFill.fillAmount -= 0.15f;
            //StatusFill01.fillAmount -= 0.3f;
            //Debug.Log(pgHP -= playerLPATK);


        }

       
        if (skHP < 0)
        {
          
            Destroy(gameObject);

        }

    }

    IEnumerator Wait()
    {

        yield return new WaitForSeconds(3f);

        Shot();
    }
    IEnumerator Shot()
    {
        animator.SetBool("Standing_Shooting", true);

        //bullet.enabled = true;
        yield return new WaitForSeconds(0.5f);

        animator.SetBool("Standing_Shooting", false);
       //bullet.enabled = false;
        Wait();
    }

}
