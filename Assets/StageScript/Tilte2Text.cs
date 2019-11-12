using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Tilte2Text : MonoBehaviour
{
    public string jaText;
    public string enText;
    public string chText;
    public Text text;

    private void Update()
    {
        int procount = 0;
        for (int i = 0; i < 200000; i++)
        {
            procount += 1;
        }
        switch (LocalDirector.language)
        {
            case Language.Japanese:
                text.text = jaText;
                break;
            case Language.English:
                text.text = enText;
                break;
            case Language.Chinese:
                text.text = chText;
                break;
        }
    }
}
