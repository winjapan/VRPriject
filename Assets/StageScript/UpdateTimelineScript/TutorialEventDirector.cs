using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TutorialEventDirector : MonoBehaviour
{
    public float tutorialTime = 500;
    public GameObject Retune;
    public GameObject Quit;
    public GameObject Md1;
    public GameObject Md2;
        
    public Canvas Pouse;

    public Text SaySub;
    public Text SaySub2;
    public Text Say;
    public Text Say2;
    public Text Say3;
    public Text Say4;
    public Text Say5;
    public Text Say6;
    public Text Say7;
    public Text Say8;
    public Text Say9;
    public Text Say10;
    public Text Say11;
    public Text Say12;
    public Text Say13;
    public Text Say14;
    public Text Say15;
    public Text Say16;
    public Text Say17;
    public Text Say18;
    public Text Say19;
    public Text Say20; 
    public Text Say21;
    public Text Say22;
    public Text Say23;
    public Text Say24;
    public Text Say25;
    public Text Say26;
    public Text Say27;
    public Text Say28;
    public Text Say29;
    public Text Say30;
    public Text Say31;
    public Text Say32;
    public Text Say33; 
    public Text Say34;

    public Text Final;
    public Text Final2;
    public Text Final3;

    public Text Timer;

    public Image RoundUp;
    public Image RoundUp2;
    public Image RoundUp3;
    public Image RoundUp4;
    public Image RoundUp5;

    public GameObject GobTes;
    public GameObject Obj;
   
    public GameObject Repair;
    public GameObject Light;
    public GameObject VRPlayer;
    public GameObject VRPlayerctrl;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        int procount = 0;
        for (int i = 0; i < 10000; i++)
        {
            procount += 1;
        }
        tutorialTime -= Time.deltaTime;

        if (tutorialTime < 498)
        {
            Say.gameObject.SetActive(true);
        }

        if (tutorialTime < 493)
        {
            Say.gameObject.SetActive(false);
        }

        if (tutorialTime < 491)
        {
            Say2.gameObject.SetActive(true);
        }

        if (tutorialTime < 486)
        {
            Say2.gameObject.SetActive(false);
        }

        if (tutorialTime < 481)
        {
            Say2.gameObject.SetActive(false);
        }

        if (tutorialTime < 479)
        {
            Say3.gameObject.SetActive(true);
        }

        if (tutorialTime < 474)
        {
            Say3.gameObject.SetActive(false);
        }

        if (tutorialTime < 469)
        {
           SaySub.gameObject.SetActive(true);
        }

        if (tutorialTime < 467)
        {
            SaySub.gameObject.SetActive(false);
        }

        if (tutorialTime < 465)
        {
            Say4.gameObject.SetActive(true);
        }


        if (tutorialTime < 460)
        {
            Say4.gameObject.SetActive(false);
        }

        if (tutorialTime < 458)
        {
            Say5.gameObject.SetActive(true);
        }

        if (tutorialTime < 453)
        {
            Say5.gameObject.SetActive(false);
        }

        if (tutorialTime < 451)
        {
            Say6.gameObject.SetActive(true);
        }


        if (tutorialTime < 444)
        {
            Say6.gameObject.SetActive(false);
        }

        if (tutorialTime < 442)
        {
            RoundUp.gameObject.SetActive(true);
        }

        if (tutorialTime < 437)
        {
            RoundUp.gameObject.SetActive(false);

        }

        if (tutorialTime < 435)
        {
            Say9.gameObject.SetActive(true);
        }


        if (tutorialTime < 430)
        {
            Say9.gameObject.SetActive(false);
        }


        if (tutorialTime < 428)
        {
            Say10.gameObject.SetActive(true);
        }


        if (tutorialTime < 420)
        {
            Say10.gameObject.SetActive(false);
        }

        if (tutorialTime < 418)
        {
            Say11.gameObject.SetActive(true);
        }


        if (tutorialTime < 413)
        {
            Say11.gameObject.SetActive(false);
        }

        if (tutorialTime < 411)
        {
            SaySub2.gameObject.SetActive(true);
        }


        if (tutorialTime < 406)
        {
            SaySub2.gameObject.SetActive(false);
        }

       
        if (tutorialTime < 404)
        {
            Say12.gameObject.SetActive(true);
            GobTes.SetActive(true);
        }

        if (tutorialTime < 399)
        {
            Say12.gameObject.SetActive(false);
        }

        if (tutorialTime < 397)
        {
            Say13.gameObject.SetActive(true);
        }

        if (tutorialTime < 392)
        {
            Say13.gameObject.SetActive(false);
        }

        if (tutorialTime < 390)
        {
            Say14.gameObject.SetActive(true);
        }

        if (tutorialTime < 385)
        {
            Say14.gameObject.SetActive(false);
            GobTes.SetActive(false);
        }

        if (tutorialTime < 383)
        {
            Say15.gameObject.SetActive(true);
        }

        if (tutorialTime < 378)
        {
            Say15.gameObject.SetActive(false);
        }

        if (tutorialTime < 376)
        {
            Say16.gameObject.SetActive(true);
        }


        if (tutorialTime < 371)
        {
            Say16.gameObject.SetActive(false);
        }

        if (tutorialTime < 369)
        {

            Say17.gameObject.SetActive(true);
            Md2.SetActive(true);
        }

        if (tutorialTime < 364)
        {
            Say17.gameObject.SetActive(false);
        }

        if (tutorialTime < 362)
        {
            Say18.gameObject.SetActive(true);
        }


        if (tutorialTime < 357)
        {
            Say18.gameObject.SetActive(false);
        }

        if (tutorialTime < 355)
        {
            Say19.gameObject.SetActive(true);
        }

        if (tutorialTime < 350)
        {
            Say19.gameObject.SetActive(false);
        }

        if (tutorialTime < 348)
        {
            Say20.gameObject.SetActive(true);
            Light.SetActive(false);
        }


        if (tutorialTime < 318)
        {
            VRPlayerctrl.SetActive(false);
            VRPlayer.SetActive(true);
        }


        if (tutorialTime < 316)
        {
            Light.SetActive(true);
            Say20.gameObject.SetActive(false);
        }


        if (tutorialTime < 311)
        {
            Say21.gameObject.SetActive(true);
            Md1.SetActive(true);
        }

        if (tutorialTime <309)
        {
            Say21.gameObject.SetActive(false);

        }

        if (tutorialTime < 307)
        {
            Say22.gameObject.SetActive(true);
        }

        if (tutorialTime < 304)
        {
            Say22.gameObject.SetActive(false);
        }

        if (tutorialTime < 302)
        {
            Say23.gameObject.SetActive(true);
        }

        if (tutorialTime < 297)
        {
            Say23.gameObject.SetActive(false);
        }

        if (tutorialTime < 295)
        {
            Say24.gameObject.SetActive(true);
        }

        if (tutorialTime < 290)
        {
            Say24.gameObject.SetActive(false);
        }

        if (tutorialTime < 285)
        {
            Say7.gameObject.SetActive(true);
        }

        if (tutorialTime < 280)
        {
            Say7.gameObject.SetActive(false);
        }

        if (tutorialTime < 275)
        {
            RoundUp2.gameObject.SetActive(true);
        }

        if (tutorialTime < 270)
        {
            RoundUp2.gameObject.SetActive(false);
        }

        if (tutorialTime < 265)
        {
            RoundUp3.gameObject.SetActive(true);
        }

        if (tutorialTime < 260)
        {
            RoundUp3.gameObject.SetActive(false);
        }

        if (tutorialTime < 255)
        {
            Say25.gameObject.SetActive(true);
        }

        if (tutorialTime < 262)
        {
            Say25.gameObject.SetActive(false);
        }

        if (tutorialTime < 260)
        {
            Say26.gameObject.SetActive(true);
        }

        if (tutorialTime < 255)
        {
            Say26.gameObject.SetActive(false);
        }

        if (tutorialTime < 250)
        {
            Say27.gameObject.SetActive(true);
        }

        if (tutorialTime < 245)
        {
            Say27.gameObject.SetActive(false);
        }

        if (tutorialTime < 240)
        {
            Say28.gameObject.SetActive(true);

            Repair.SetActive(true);
        }

        if (tutorialTime < 235)
        {
            Say28.gameObject.SetActive(false);

            Repair.SetActive(false);
        }


        if (tutorialTime < 230)
        {
            Say29.gameObject.SetActive(true);
            Timer.gameObject.SetActive(true);
        }

        if (tutorialTime < 225)
        {
            Say29.gameObject.SetActive(false);
            Timer.gameObject.SetActive(false);
        }

        if (tutorialTime < 220)
        {
            RoundUp4.gameObject.SetActive(true);
        }

        if (tutorialTime < 195)
        {
            RoundUp4.gameObject.SetActive(false);
        }

        if (tutorialTime < 190)
        {
            RoundUp5.gameObject.SetActive(true);
        }

        if (tutorialTime < 185)
        {
            RoundUp5.gameObject.SetActive(false);
        }

        if (tutorialTime < 180)
        {
            Say30.gameObject.SetActive(true);
        }

        if (tutorialTime < 175)
        {
            Say30.gameObject.SetActive(false);
        }

        if (tutorialTime < 170)
        {
            Say31.gameObject.SetActive(true);
            Retune.SetActive(true);
            Quit.SetActive(true);
            Pouse.gameObject.SetActive(true);
        }

        if (tutorialTime < 165)
        {
            Say31.gameObject.SetActive(false);
        }

        if (tutorialTime < 160)
        {
            Say32.gameObject.SetActive(true);
        }

        if (tutorialTime < 155)
        {
            Say32.gameObject.SetActive(false);
        }
        if (tutorialTime < 150)
        {
            Say33.gameObject.SetActive(true);
        }

        if (tutorialTime < 145)
        {
            Say33.gameObject.SetActive(false);
            Retune.SetActive(false);
            Quit.SetActive(false);
            Pouse.gameObject.SetActive(false);
        }

       

        if (tutorialTime < 140)
        {
            Say34.gameObject.SetActive(true);
        }

        if (tutorialTime < 135)
        {
            Say34.gameObject.SetActive(false);
        }

        if (tutorialTime < 130)
        {
            Final.gameObject.SetActive(true);
            Final2.gameObject.SetActive(true);
            Final3.gameObject.SetActive(true);
            Obj.SetActive(true);
        }
    }
}
