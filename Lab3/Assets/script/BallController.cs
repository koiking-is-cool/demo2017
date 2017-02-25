using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BallController : MonoBehaviour {
	public Rigidbody rg;
	public float speed;
	public TextMesh txtBall;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void DoJump(){
		rg.velocity = new Vector3 (0,speed,0);
	}
	int cntCollosion = 0;
	void OnCollosionEnt(Collision collision){
		Debug.LogFormat ("collision is {0}",collision.gameObject.tag);
		if (collision.gameObject.tag == "floor"){
			cntCollosion++;
			txtBall.text = "Floor : " + cntCollosion.ToString ();
		}
	}

	System.Action
	void OnDestroy(){
		sceneballcontroller.life--;
		GameObject dieEffect = Instantiate (dieEffectPrefab);
		dieEffect.transform.position = this.gameObject.transform.position;
		dieCallBack();
	}
}
