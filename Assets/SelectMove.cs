using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectMove : MonoBehaviour
{
    public Canvas Dummy;
    public Canvas Select;
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
        Dummy.gameObject.SetActive(false);
        Select.gameObject.SetActive(true);
    }
}
