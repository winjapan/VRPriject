using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSearch : MonoBehaviour
{
    public GameObject target;
    public bool playerClosing;
    SphereCollider sphereCol;
   // private PoogyeeAttack poogyee;

    Animator animator;
    // Start is called before the first frame update
    void Start()
    {
        sphereCol = GetComponent<SphereCollider>();
       // poogyee = GetComponent<PoogyeeAttack>();
    }

    private void OnTriggerStay(Collider col)
    {
        //プレイヤー検出！！！
        if (col.tag == "Player")
        {
           //PoogyeeAttack.PoogyeeState state = poogyee.GetState();
            playerClosing = true;
            sphereCol.radius = 0.007f;

        }
    }

    private void TriggerExit(Collider col)
    {
    //検出終了後は、元にもどす
        playerClosing = false;
        sphereCol.radius = 0.007f;
    }

   
}
