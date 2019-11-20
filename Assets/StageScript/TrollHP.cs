using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TrollHP : MonoBehaviour
{
    public int trollHP = 300;

    public int playerRPATK = 10;
    public int playerLPATK = 10;
    public int playerKATK = 20;


    public Image trollFill;
    public GameObject Light;
    public GameObject ExplosionEffect;
    private Animator animator;
    private AudioSource audioSource;
    public AudioClip trollCry;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        trollFill = GameObject.Find("TrollFill").GetComponent<Image>();
        trollFill.fillAmount = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        //右パンチダメージ
        if (hit.gameObject.tag == "RPunch")
        {
            Light.SetActive(true);
            Invoke("EndDamage", 0.3f);
            trollHP -= playerRPATK;
            trollFill.fillAmount -= 0.019f;


        }

        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {
            Light.SetActive(true);
            Invoke("EndDamage", 0.3f);
            trollHP -= playerLPATK;
            trollFill.fillAmount -= 0.05f;

        }

        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {
            Light.SetActive(true);
            Invoke("EndDamage", 0.3f);
            trollHP -= playerKATK;
            trollFill.fillAmount -= 0.05f;
            animator.SetTrigger("take_damage");
        }


        if (hit.gameObject.tag == "LKick")
        {
            Light.SetActive(true);
            Invoke("EndDamage", 0.3f);
            trollHP -= playerKATK;
            trollFill.fillAmount -= 0.07f;
            //Debug.Log(pgHP -= playerKATK);
        }



        if (trollHP < 0)
        {
            //audioSource.PlayOneShot(trollCry);

            animator.SetTrigger("death");
            Invoke("Death", 0.5f);
            GameObject.Find("BossBGM\ud83c\udd71").GetComponent<AudioSource>().enabled = false;
        }

    }
    void EndDamage()
    {
        Light.SetActive(false);
    }

    void Death()
    {
        Destroy(gameObject);
        //  audioSource.PlayOneShot(Ex);
        var Explode = Instantiate(ExplosionEffect, transform.position + Vector3.forward, Quaternion.FromToRotation(Vector3.forward, transform.forward));
        GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = true;

    }
}
