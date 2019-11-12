using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalTextCh : MonoBehaviour
{
    [Multiline]
    public string chineseText;
    public int chineseFontSize;

void OnButtonClicked()
    {
        this.enabled = true;
    }

    // Start is called before the first frame update
    public void Start()
    {
        Text text = GetComponent<Text>();
        if (Application.systemLanguage != SystemLanguage.Chinese)
        {
            text.text = chineseText;
            if (chineseFontSize != 0)
            {
                text.fontSize =chineseFontSize;
            }
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
