using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;



public class Settings : MonoBehaviour {
	bool isFullScreen = Screen.fullScreen;
	public void FullScreenToggle(){
        isFullScreen = !isFullScreen;
        Screen.fullScreen = isFullScreen;
		if(!isFullScreen){
			Debug.Log("ZERO");
		}
		else{
			Debug.Log("ONE");
		}
    }
	public void Quality(int q)
    {
        QualitySettings.SetQualityLevel(q);
    }

}
