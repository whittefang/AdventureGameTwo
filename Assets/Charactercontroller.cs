using UnityEngine;
using System.Collections;

public class Charactercontroller : MonoBehaviour {
	public bool touchingWallLeft = false;
	bool touchingWallRight = false;
	bool touchingWallUp = false;
	bool touchingWallDown = false;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if ((Input.GetKey(KeyCode.W)) && (touchingWallUp == false)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);

			transform.Translate(new Vector3(0,5,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.S)) && (touchingWallDown == false)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);
			
			transform.Translate(new Vector3(0,-5,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.A)) && (touchingWallRight == false)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);
			
			transform.Translate(new Vector3(-5,0,0) * Time.deltaTime);
		}
		if ((Input.GetKey(KeyCode.D)) && (touchingWallLeft == false)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);
			
			transform.Translate(new Vector3(5,0,0) * Time.deltaTime);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "wall"){
			touchingWallLeft = true;
		}
	}
}
