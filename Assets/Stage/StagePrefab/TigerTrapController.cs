using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TigerTrapController : MonoBehaviour
{
   public Animator animator;

    private float footwaitetime = 0.5f;

    public float waitTime = 3;

    public Rigidbody playerrgbody;
    public GameObject Tunning;

    public GameObject Player3;
    public GameObject PlayerEv;
    public GameObject Player2;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<Animator>();
        waitTime = 3;
    }

    void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            animator.enabled = true;

            Player3.SetActive(false);
            PlayerEv.SetActive(true);

            Invoke("Stop", 10f);
            Debug.Log("aaa");
        }

      
    }
    void Stop()
    {
        PlayerEv.SetActive(false);
        Player2.SetActive(true);
    }


}
