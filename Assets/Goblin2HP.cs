using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Goblin2HP : MonoBehaviour
{
    public Image gob2Fill;

    public int gobHP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 15;
    public int playerKATK = 20;

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        gob2Fill = GameObject.Find("Gob2Fill").GetComponent<Image>();
        gobHP = 100;
        gob2Fill.fillAmount = 1;
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


            gobHP -= playerRPATK;
            gob2Fill.fillAmount -= 0.1f;

            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {


            gobHP -= playerLPATK;
            gob2Fill.fillAmount -= 0.15f;

            Debug.Log("Damage");


        }


        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            gobHP -= playerKATK;
            gob2Fill.fillAmount -= 0.2f;

            Debug.Log("Damage");
        }

        if (gobHP < 1)
        {
            animator.SetTrigger("death");
            Destroy(gameObject, 0.5f);
        }

    }
}
