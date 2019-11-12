using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class SetLadyPilate : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.Find("Lady Pirate").GetComponent<NavMeshAgent>().enabled = true;
        GameObject.Find("Lady Pirate").GetComponent<LadyPirateController>().enabled = true;
        GameObject.Find("Lady Pirate").GetComponent<LadyPirateHP>().enabled = true;
        Invoke("OFF",0.1f);
    }

    void OFF()
    {
        this.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
