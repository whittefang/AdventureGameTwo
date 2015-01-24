using UnityEngine;
using System.Collections;

public class Charactercontroller : MonoBehaviour {
	public GameObject rightCheck;
	public GameObject leftCheck;
	public GameObject upCheck;
	public GameObject downCheck;
	public GameObject SpriteGraphic;
	public GameObject vineCheckerObj;
	bool touchingWallLeft = false;
	bool touchingWallRight = false;
	bool touchingWallUp = false;
	bool touchingWallDown = false;
	//states 1=left, 2=right, 3=up, 0=down
	public int facingState = 1;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		//movement controls check for wall and button push
		// checks for facing and rotates accordingly
		checkerWall ();
		if ((Input.GetKey(KeyCode.W)) && (touchingWallUp == false)){
			if (!FindFacingState(3)){ SpriteGraphic.transform.rotation = (Quaternion.Euler(0,0,270));}
			transform.Translate(new Vector3(0,5,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.S)) && (touchingWallDown == false)){
			if (!FindFacingState(0)){ SpriteGraphic.transform.transform.rotation =(Quaternion.Euler(0,0,90));}
			transform.Translate(new Vector3(0,-5,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.A)) && (touchingWallLeft == false)){
			if (!FindFacingState(1)){ SpriteGraphic.transform.transform.rotation =(Quaternion.Euler(0,0,0));}
			transform.Translate(new Vector3(-5,0,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.D)) && (touchingWallRight == false)){
			if (!FindFacingState(2)){ SpriteGraphic.transform.transform.rotation = (Quaternion.Euler(0,0,180));}
			transform.Translate(new Vector3(5,0,0) * Time.deltaTime);
		}
		// inputs for machete 
		if (Input.GetKey(KeyCode.J)){
			VineCheck();
		}
	
	}
	// fucntion to get collision info from children colliders
	// sets wall collisition state
	void checkerWall(){

		if (downCheck.GetComponent<Checker> ().CheckWall ()) {
			touchingWallDown = true;	
		} else {touchingWallDown = false;}

		if (leftCheck.GetComponent<Checker>().CheckWall()) {
			touchingWallLeft = true;	
		}else {touchingWallLeft = false;}
		if (rightCheck.GetComponent<Checker>().CheckWall()) {
			touchingWallRight = true;	
		}else {touchingWallRight = false;}
		if (upCheck.GetComponent<Checker>().CheckWall()) {
			touchingWallUp = true;	
		}else {touchingWallUp = false;}
	}
	//checks to see if facing the same way then changes if not
	bool FindFacingState(int checkedState){
		bool sameState = false;
		if (checkedState == facingState){
			sameState = true;
		}else { facingState = checkedState;}
		return sameState;
	}

	// vine detection
	void VineCheck(){
		vineCheckerObj.GetComponent<VineChecker>().CheckVine();
	}

}
