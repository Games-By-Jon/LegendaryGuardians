//============================================================//
//                         Menu System                        //
//============================================================//
//                  Created: 2019-03-21 11:59 pm              //
//                  Updated: 2019-03-21                       //
//                  Version 1.0.0                             //
//                  Revisions 1                               //
//============================================================//
// Author: Jonathan Thompson                                  //  
// Contact: @programmerJon | Mr.j.thompson@hotmail.ca         //
//============================================================//
// Used to play my video logo intro.                          //
//============================================================//
//                   Resvision notes:                         //
//                                                            //
//                                                            //
//============================================================//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //Canvases
    public Canvas mainMenuCanvas;
    public Canvas creditsCanvas;

    //Images
    public Image splashTitle;

    //bools
    private bool splashTitleVisable;
    // Start is called before the first frame update
    void Start()
    {
        splashTitle.enabled = true;
        splashTitleVisable = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Joystick1Button1) && splashTitleVisable){
            Debug.Log("X Pressed");
            HideSplashTitle();
        }
    }

    void HideSplashTitle(){
        splashTitle.enabled = false;
        splashTitleVisable = false;
    }
}
