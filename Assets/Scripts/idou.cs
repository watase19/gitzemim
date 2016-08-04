using UnityEngine;
using System.Collections;

public class idou : MonoBehaviour {
	public GameObject player;
	public Vector3 playerp;
	// Use this for initialization
	void Start () {
		playerp = player.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.RightArrow)) {
				playerp.x+=0.1f;
		}
		if (Input.GetKey (KeyCode.LeftArrow)) {
				playerp.x-=0.1f;
		}
		player.transform.position = playerp;
	}
}
