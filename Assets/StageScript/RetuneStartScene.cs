using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class RetuneStartScene : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        Invoke("Retune", 3f);

        
}

    // Update is called once per frame
    void Update()
    {

    }

    void Retune()
    {
        SceneManager.LoadScene("StartSceene");
    }

}
