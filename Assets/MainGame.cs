using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using end_of_day;

public class MainGame : MonoBehaviour {
	/*
	void Update () {
		if(Input.GetKeyDown(KeyCode.Escape)){
			_menuWindow = true;
			Time.timeScale = 0f;
		}
	}

	void OnGUI(){
		if(_menuWindow){
			menuWindow();
		}
	}
	private void menuWindow(){
		GUI.Box(new Rect(0f, 0f, Screen.width, Screen.height), "");
		if(GUI.Button(new Rect(Screen.width * 0.5f - 50, Screen.height * 0.5f - 15, 100f, 30f), "smt")){
			Time.timeScale = 1f;
			_menuWindow = false;
		}
	}*/
	// Use this for initialization
	void Start () {
		script.end_of_day();
	}

	// Update is called once per frame
	void Update () {

	}
}
