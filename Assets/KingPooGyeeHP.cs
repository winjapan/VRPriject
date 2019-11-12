using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class KingPooGyeeHP : MonoBehaviour
{
    public Image StatusFill00;

    public int kpgHP = 550;
    public int playerRPATK = 5;
    public int playerLPATK = 10;
    public int playerKATK = 15;
    public int playerIVCATK = 20;

    public GameObject GoldenMagicDragonOrb;
    public GameObject Explode;
    public GameObject KingPoogyee;

    public GameObject Light;
    public AudioSource playerSouce;
    public AudioSource IvcSouce;
    // Start is called before the first frame update
    void Start()
    {
        StatusFill00 = GameObject.Find("Status Fill 00").GetComponent<Image>();
        StatusFill00.fillAmount = 1;
        kpgHP = 400;
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
            Invoke("EndDamage", 1f);
            kpgHP -= playerRPATK;
            StatusFill00.fillAmount -= 0.019f;
            Light.SetActive(true);
            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }

        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {
            Light.SetActive(true);
            kpgHP -= playerLPATK;
            StatusFill00.fillAmount -= 0.019f;
            //StatusFill01.fillAmount -= 0.3f;
            //Debug.Log(pgHP -= playerLPATK);
            Invoke("EndDamage",1f);

        }

        //もし、プレイヤーが無敵（仁者無敵）だったら
        //与えるダメージを二倍にする

        if (hit.gameObject.tag == "IVCSword")
        {
            Light.SetActive(true);
            Invoke("EndDamage", 1f);
            kpgHP -= playerIVCATK;
            StatusFill00.fillAmount -= 0.05f;
            Debug.Log(Light);

        }

        //プーギーのHPが０になったら
        //プーギーを消滅させる
        //０以下からは、HPを変動させない
        if (kpgHP <= 0)
        {
            Invoke("Death", 0.5f);
        }

    }

    void Death()
    {

        KingPoogyee.SetActive(false);
        GoldenMagicDragonOrb.gameObject.SetActive(true);
        var deadEx = Instantiate(Explode, transform.position, Quaternion.identity);
        GameObject.Find("InvincibleBGM").GetComponent<AudioSource>().enabled = false;
        GameObject.Find("ClearBGM").GetComponent<AudioSource>().enabled = true;
        playerSouce.enabled = false;
        IvcSouce.enabled = false;
       

    }

    void EndDamage()
    {
        Light.SetActive(false);
    }
}
