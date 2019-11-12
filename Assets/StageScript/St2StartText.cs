using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class St2StartText : MonoBehaviour
{
    public Text Starttext;
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(Intorduction());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Intorduction()
    {
        yield return new WaitForSeconds(1f);

        Starttext.gameObject.SetActive(false);
    }
}
