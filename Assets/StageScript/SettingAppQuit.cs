using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingAppQuit : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
       
    }

    void QuitGame()
    {
     
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void OnButtonClicked()
    {
        Application.Quit();
        Debug.Log("Quit");
    }
}
