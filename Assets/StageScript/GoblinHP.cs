using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoblinHP : MonoBehaviour
{
    public Image gobFill;

    public int gobHP = 100;
    public int playerRPATK = 25;
    public int playerLPATK = 25;
    public int playerKATK = 40;

    private Animator animator;


    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        gobFill = GameObject.Find("GobFill").GetComponent<Image>();
        gobHP = 100;
        gobFill.fillAmount = 1;
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
            gobFill.fillAmount -= 0.1f;

            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {
          

            gobHP -= playerLPATK;
            gobFill.fillAmount -= 0.15f;

            Debug.Log("Damage");


        }
       

        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            gobHP -= playerKATK;
            gobFill.fillAmount -= 0.20f;
           
            Debug.Log("Damage");
        }

        if (gobHP < 1)
        {
            animator.SetTrigger("death");
            Destroy(gameObject,0.5f);
                   }

    }
}
