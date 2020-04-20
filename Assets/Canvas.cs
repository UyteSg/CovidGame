using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Canvas : MonoBehaviour {
	public void MenuPressed(){
		SceneManager.LoadScene("Menu");
	}
}
