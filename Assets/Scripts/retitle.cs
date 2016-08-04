using UnityEngine;
using System.Collections;

public class no : MonoBehaviour {

	public float time = 0;
	private float st_time;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		
		time += Time.deltaTime;
		if (time >= st_time) {
			
			Application.LoadLevel ("Title");
		}
	
	}
}
