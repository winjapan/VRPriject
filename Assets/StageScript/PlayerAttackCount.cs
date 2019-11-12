using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAttackCount : MonoBehaviour
{
    public Text AttackCount;

    public int playerATKCount;
    public int count;
    // Start is called before the first frame update
    void Start()
    {
        playerATKCount = 0;
        count = 1; 
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider hit)
    {
        //右パンチ計測
        if (hit.gameObject.tag == "RPunch")
        {


            playerATKCount += 1;
            AttackCount.text = playerATKCount.ToString();
            Debug.Log("aaa");
            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }


        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")

        {

            playerATKCount += 1;
            AttackCount.text = playerATKCount.ToString();


        }


        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            playerATKCount += 1;
            AttackCount.text = playerATKCount.ToString();
        }

    }
}

