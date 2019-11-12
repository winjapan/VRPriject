using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalTextEn : MonoBehaviour
{
    [Multiline]
    public string englishText;
    public int englishFontSize;
    // Start is called before the first frame update
    void Start()
    {
        Text text = GetComponent<Text>();
        if (Application.systemLanguage != SystemLanguage.English)
        {
            text.text = englishText;
            if (englishFontSize != 0)
            {
                text.fontSize = englishFontSize;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
