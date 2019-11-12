using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FallTimeOutCeil : MonoBehaviour
{
    public GameObject Ceiling;
    public GameObject Player;
    public int celCount;
    public int celMax ;

    // Start is called before the first frame update
    void Start()
    {
        celCount = 0;
    }

    public void Update()
    {
        //落ちる天上が作動するとき（時間が0の場合）
        //プレイヤーHPでこのスクリプトを作動させて、落ちる天上を落とす
        //落ちた後は、セルカウントを０に戻す
        if (celCount < celMax)
        {

            var cel = Instantiate(Ceiling, Player.transform.position, Quaternion.identity) as GameObject;
            celCount += 1;
            Destroy(cel, 2.0f);

            Invoke("RetuneCel",1f);
        }
    }
   public void RetuneCel()
    {
        Start();
    }
}
