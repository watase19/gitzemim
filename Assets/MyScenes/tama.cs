using UnityEngine;
using System.Collections;

public class tama : MonoBehaviour {
	public GameObject ball;
	public Vector3 ballp;
	int ballflgx=0;
	int ballflgy=0;
	// Use this for initialization
	void Start () {
		ballp = ball.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (ballflgy == 0) {
			ballp.y -= 0.1f;
		} else {
			ballp.y += 0.1f;
		}
		if (ballflgx == 0) {
			ballp.x -= 0.1f;
		} else {
			ballp.x += 0.1f;
		}
		if (ballp.x >= 11f) {
			ballflgx = 0;
		}
		if(ballp.x<=-11f){
			ballflgx=1;
		}
		if (ballp.y >= 13.7f) {
			ballflgy = 0;
		}
		ball.transform.position = ballp;
	}
	void OnCollisionEnter(Collision other){
		ballflgy = 1 ;
	}
}
