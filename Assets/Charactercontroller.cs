using UnityEngine;
using System.Collections;

public class Charactercontroller : MonoBehaviour {
	public GameObject rightCheck;
	public GameObject leftCheck;
	public GameObject upCheck;
	public GameObject downCheck;
	bool touchingWallLeft = false;
	bool touchingWallRight = false;
	bool touchingWallUp = false;
	bool touchingWallDown = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		checker ();
		if ((Input.GetKey(KeyCode.W)) && (touchingWallUp == false)){
			transform.Translate(new Vector3(0,5,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.S)) && (touchingWallDown == false)){
			transform.Translate(new Vector3(0,-5,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.A)) && (touchingWallLeft == false)){
			transform.Translate(new Vector3(-5,0,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.D)) && (touchingWallRight == false)){
			transform.Translate(new Vector3(5,0,0) * Time.deltaTime);
		}
	
	}
	void checker(){

		if (downCheck.GetComponent<DownDetector> ().CheckIt ()) {
			Debug.Log ("Main Checker down");
			touchingWallDown = true;	
		} else {touchingWallDown = false;}
		if (leftCheck.GetComponent<LeftDetector>().CheckIt()) {
			Debug.Log("Main Checker up");
			touchingWallLeft = true;	
		}else {touchingWallLeft = false;}
		if (rightCheck.GetComponent<RightDetector>().CheckIt()) {
			Debug.Log("Main Checker right");
			touchingWallRight = true;	
		}else {touchingWallRight = false;}
		if (upCheck.GetComponent<TopDetector>().CheckIt()) {
			Debug.Log("Main Checker left");
			touchingWallUp = true;	
		}else {touchingWallUp = false;}
	}
	/*void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "wall"){
			touchingWallLeft = true;
		}
	}*/
}
