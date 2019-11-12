using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class TigerPoint : MonoBehaviour
{
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }
   void OnTriggerEnter(Collider hit)
    {
        if (hit.gameObject.tag == "Player")
        {
            GameObject.Find("Tiger").GetComponent<NavMeshAgent>().enabled = true;
        }
    }
}
