using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneballcontroller : MonoBehaviour {
	public Text txtScore;
	public Text txtAtk;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	int score = 0;
	int atk = 10;
	public void DoPushBtn(){
		score++;
		atk += 2;
		txtScore.text = "Score :" + score.ToString ();
		txtAtk.text = "Attack :" + atk.ToString ();
	}
	public void DoChangeScene(){
		SceneManager.LoadScene (0);
	}
}