using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class sceneballcontroller : MonoBehaviour {
	public Text txtScore;
	public Text txtAtk;
	public Text txtLife;

	public GameObject obtaclePrefab;
	public GameObject moneyPrefab;
	public GameObject ballPrefab;
	// Use this for initialization
	void Start () {
		DoTestObtacle ();
	}
	
	// Update is called once per frame
	void Update () {
		UpdateTxt ();
	}

	void UpdateTxt(){
		txtScore.text = "Score :" + score.ToString ();
		txtLife.text = "Life :" + life.ToString ();
	}

	public static int score = 0;
	int atk = 10;
	int life = 5;
	public void DoPushBtn(){
		score++;
		atk += 2;
		txtScore.text = "Score :" + score.ToString ();
		txtAtk.text = "Attack :" + atk.ToString ();
	}

	public void DoChangeScene(){
		SceneManager.LoadScene (1);
	}

	public void DoTestObtacle(){
		StartCoroutine (GameProcess());
	}

	IEnumerator GameProcess(){
		for(int i=0;i<20;i++){
			GameObject obtacle = Instantiate (obtaclePrefab);
			float positionY = Random.Range (-1f,-1f);
			obtacle.transform.position = new Vector3 (4f,positionY,0);

			GameObject money = Instantiate (moneyPrefab);
			money.transform.position = new Vector3 (4f,positionY+1f+Random.Range(-0.01f,0.01f),0);
			yield return new WaitForSeconds (1);
		}
	}
	void CreateBall(){
		Instantiate (ballPrefab).GetComponent<BallController> ().SetDieCallBack (CreateBall);
	}
}