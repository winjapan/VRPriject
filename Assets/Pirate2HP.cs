using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Pirate2HP : MonoBehaviour
{
    public int pt2HP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 15;
    public int playerKATK = 20;

    private Animator animator;

    public Image pirate2Fill;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        pirate2Fill = GameObject.Find("Pirate2Fill").GetComponent<Image>();
        pt2HP = 100;
        pirate2Fill.fillAmount = 1;
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


            pt2HP -= playerRPATK;
            pirate2Fill.fillAmount -= 0.1f;

            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {


            pt2HP -= playerLPATK;
            pirate2Fill.fillAmount -= 0.15f;

            Debug.Log("Damage");


        }


        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            pt2HP -= playerKATK;
            pirate2Fill.fillAmount -= 0.20f;

            Debug.Log("Damage");
        }

        if (hit.gameObject.tag == "LKick")
        {

            pt2HP -= playerKATK;
            pirate2Fill.fillAmount -= 0.20f;

            Debug.Log("Damage");
        }

        if (pt2HP < 1)
        {
            animator.SetTrigger("Death2");
            Invoke("Death", 1f);
        }
    }

    void Death()
    {
        Destroy(gameObject, 1f);
    }
}
