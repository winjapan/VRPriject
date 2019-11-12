using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Stage2BGM : MonoBehaviour
{
    public GameObject DestPoint;
    public GameObject BossBGM;
    public TrollController troll;
    public Text Hint;
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
        //  Destroy(DestPoint);
        GameObject.Find("BossBGM\ud83c\udd71").GetComponent<AudioSource>().enabled = true;
            GameObject.Find("Main Camera").GetComponent<AudioSource>().enabled = false;
            GameObject.Find("troll").GetComponent<TrollController>().enabled = true;
            Hint.gameObject.SetActive(false);
            Hint2.gameObject.SetActive(true);

        }
    }
}
