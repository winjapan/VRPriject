using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPBarController : MonoBehaviour
{

    public GameObject player;
    PlayerHP hpcomp;
   public Image fill00;



    private int hp;
    // Start is called before the first frame update
    void Start()
    {
        //プレイヤーHPを検知する
        player = GameObject.Find("ma");
       

        //HPバー取得の為に、HPバーのイメージも取得
        fill00 = GameObject.Find("Fill00").GetComponent<Image>();
      
       
    }

    // Update is called once per frame
    void Update()
    {
        hpcomp = GetComponent<PlayerHP>();
        fill00.fillAmount = 1;
    }
}
