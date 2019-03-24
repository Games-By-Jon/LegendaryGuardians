//============================================================//
//                         Video Intro                        //
//============================================================//
//                  Created: 2018-01-31 11:59 pm              //
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
// added a skip feature                                       //
//                                                            //
//============================================================//
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class VideoLogoIntro : MonoBehaviour {
    public enum ScreenLayout
	{
		LANDSCAPE,
		PORTRAIT
	};
    [Header("Video Clips To Play")]
    public VideoClip Clip01;
    [Header("Video Clip Properties")]

    public int playSpeed;
	public float timer;
	public bool videoIsOver = false;

	public Image copyrightIMG;
    public VideoPlayer introClipPlayer;
	void Awake(){
		GameObject camera = GameObject.Find("Main Camera");
		copyrightIMG.enabled = false;
		introClipPlayer.loopPointReached += EndReached;
		if(introClipPlayer.isPlaying) {
            EndReached(introClipPlayer);
        }
		
		introClipPlayer.Play();
		
	}
	void Update(){
		if(Input.anyKeyDown && !videoIsOver){
        	//SceneManager.LoadScene("MainMenu");
            EndReached(introClipPlayer);
		}
		if(videoIsOver){
			timer += Time.deltaTime;
		}

		if(timer >= 5f || timer > 2.5f && Input.anyKeyDown){
			SceneManager.LoadScene("MainMenu");
		}
	}
    void EndReached(VideoPlayer vp){
		videoIsOver = true;
		copyrightIMG.enabled = true;
        //SceneManager.LoadScene("MainMenu");
	}
}
