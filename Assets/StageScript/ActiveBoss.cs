using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActiveBoss : MonoBehaviour
{
    public GameObject DestPoint;
    public GameObject trollBar;
    public GameObject Player;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == " Player")
        {
            Destroy(DestPoint);
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("BossBGM").GetComponent<AudioSource>().enabled = true;
            GameObject.Find("troll").GetComponent<TrollController>().enabled = true;
            Debug.Log(DestPoint);
        }
    }
}
