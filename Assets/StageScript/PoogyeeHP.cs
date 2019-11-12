using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PoogyeeHP : MonoBehaviour
{
    public AudioClip PoogyeeCryVoice;

    public int maxHP = 100;
    public int pgHP = 100;
    public int playerRATK = 10;
    public int playerLPATK = 10;
    public int playerKATK = 15;



    public Image StatusFill01;
    public GameObject Poogyee;


   // AudioSource source;

    // Start is called before the first frame update
    void Start()
    {
       
        //hPBar = GetComponent<HPBarController>();
        //HPバー取得の為に、HPバーのイメージも取得
        //mabody2Col = GameObject.Find("MA Body 2").GetComponent<CapsuleCollider>();
        StatusFill01 = GameObject.Find("Status Fill 01").GetComponent<Image>();
        StatusFill01.fillAmount = 1;
    }

    void Update()
    {

        }

    private void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "RPunch")
        {

            pgHP -= playerRATK;
            StatusFill01.fillAmount -= 0.1f;
            //Debug.Log(pgHP -= playerLATK);
        }
            if (hit.gameObject.tag == "LPunch")
            {
            pgHP -= playerLPATK;
            StatusFill01.fillAmount -= 0.1f;
            Debug.Log(pgHP -= playerLPATK);
        }

        if (hit.gameObject.tag == "Kick")
        {
            pgHP -= playerKATK;
            StatusFill01.fillAmount -= 0.15f;
            Debug.Log(pgHP -= playerKATK);
        }

        if (hit.gameObject.tag == "LKick")
        {
            pgHP -= playerKATK;
            StatusFill01.fillAmount -= 0.15f;
            Debug.Log(pgHP -= playerKATK);
        }
        //プーギーのHPが０になったら
        //プーギーを消滅させる
        //０以下からは、HPを変動させない
        if (pgHP <= 0)
            {
                Destroy(transform.root.gameObject);
}
    }

}
