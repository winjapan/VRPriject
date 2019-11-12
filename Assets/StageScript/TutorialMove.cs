using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TutorialMove : MonoBehaviour
{
    public Button TutorialButton;

    private Button button;
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
       
         SceneManager.LoadScene("TutorialScene");
    }
}
