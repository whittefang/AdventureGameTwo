using UnityEngine;
using System.Collections;

public class Checker : MonoBehaviour {

	bool IsTouching = false;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "wall") {
			IsTouching = true;
		}

	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "wall") {
			IsTouching = false;
		}
	}
	
	public bool CheckWall(){
		return IsTouching;
	}
}
