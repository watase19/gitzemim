using UnityEngine;
using System.Collections;

public class DualHit : MonoBehaviour {
	int cnt;
	// Use this for initialization
	void Start () {
		cnt = 0;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	
	void OnCollisionEnter(Collision other){
		cnt++;
		if (cnt == 2) {
			Destroy (this.gameObject);
			cnt = 0;
		}
	}
}
