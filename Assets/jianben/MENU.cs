using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MENU : MonoBehaviour {
	public allen a;
	//public GameObject text;
	//public GameObject inputtext;
	void Start(){
		Cursor.visible =true;
	}
	public void OnStartButtonClicked(){
		SceneManager.LoadScene ("MINIGUN");
	}
	// Use this for initialization
	// Update is called once per frame
	public void easy(){
		a.hp = 100;
	}

	public void hard(){
		a.hp = 500;
	}
	public void quit(){
		Application.Quit ();
	}
	//mouse stay
	void Update(){
		Cursor.visible = true;
		Cursor.lockState = 0;
	}
}
