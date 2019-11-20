using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RetuneToSelect : MonoBehaviour
{
    public Canvas Dummy;
    public Canvas Image;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void OnButtonClicked()
    {
        Image.gameObject.SetActive(false);
        Dummy.gameObject.SetActive(true);
    }
}
