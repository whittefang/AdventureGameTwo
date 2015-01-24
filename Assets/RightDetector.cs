using UnityEngine;
using System.Collections;

public class RightDetector : MonoBehaviour {
	bool IsTouching = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "wall") {
			Debug.Log("right colision");
			IsTouching = true;
		}
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "wall") {
			IsTouching = false;
		}
	}
	public bool CheckIt(){
		return IsTouching;
	}
}
