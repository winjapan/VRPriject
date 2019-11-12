using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SeekerGirl : MonoBehaviour
{

    public int sk2HP = 100;
    public int playerRPATK = 10;
    public int playerLPATK = 15;
    public int playerKATK = 20;
    public int playerDBATK = 30;
    public int tornadoATK = 10;


    public Image sk2Fill;

    // Start is called before the first frame update
    void Start()
    {
        sk2Fill = GameObject.Find("Status Fill 010").GetComponent<Image>();
        sk2Fill.fillAmount = 1;
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

            sk2HP -= playerRPATK;
            sk2Fill.fillAmount -= 0.3f;
            // StatusFill01.fillAmount -= 0.1f;
            // Debug.Log(pgHP -= playerRPATK);
        }

        //左パンチダメージ
        if (hit.gameObject.tag == "LPunch")
        {

            sk2HP -= playerLPATK;
            sk2Fill.fillAmount -= 0.3f;
            Debug.Log("Damage");


        }

        //キックダメージ
        if (hit.gameObject.tag == "Kick")
        {

            sk2HP -= playerKATK;
            sk2Fill.fillAmount -= 0.2f;
            Debug.Log("Damage");
        }

        if (hit.gameObject.tag == "DUpper")
        {

            sk2HP -= playerDBATK;
            sk2Fill.fillAmount -= 0.3f;
            Debug.Log("Damage");

        }

        if (hit.gameObject.tag == "Tornado")
        {
            sk2HP -= tornadoATK;
            sk2Fill.fillAmount -= 0.1f;
            Debug.Log("Damage");
        }
    }
}
