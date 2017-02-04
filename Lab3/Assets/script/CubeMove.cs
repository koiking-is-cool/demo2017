using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMove : MonoBehaviour {
	public Rigidbody rg;
	public float velocity;
	// Use this for initialization
	void Start () {
		rg.velocity = new Vector3 (velocity, 0, 0);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
