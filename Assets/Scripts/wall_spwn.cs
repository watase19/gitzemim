using UnityEngine;
using System.Collections;

public class wall_spwn : MonoBehaviour {
	public GameObject wall;
	double wall_spc=0.5;
	float x;
	float y;
	// Use this for initialization
	void Start () {
		for(x=-3f;x<=3f;x+=(float)wall_spc){
			for(y=-4.75f;y<=4.75f;y+=(float)wall_spc){
				if((x==-3f)||(x==3f)||(y==-4.75f)||(y==4.75f)){
					transform.position=new Vector3(x,y,1);
					Instantiate(wall,transform.position,transform.rotation);
				}
			}
		}

	}

	// Update is called once per frame
	void Update () {
	}
}
