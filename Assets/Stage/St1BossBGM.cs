using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class St1BossBGM : MonoBehaviour
{
    public GameObject DestPoint;
    public GameObject KingPooGyee;
    public Text Hint1;
    public Text Hint2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Player")
        {
            KingPooGyee.gameObject.SetActive(true);
            Hint1.gameObject.SetActive(false);
            Hint2.gameObject.SetActive(true);
            Destroy(DestPoint);
            GameObject.Find("InsectBGM").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = true;

        }
    }
}
