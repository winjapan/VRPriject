using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintDirector : MonoBehaviour
{
    public Canvas Dummy;
    public Canvas Hint;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnButtonClieked()
    {
        Dummy.gameObject.SetActive(false);
        Hint.gameObject.SetActive(true);
    }
}
