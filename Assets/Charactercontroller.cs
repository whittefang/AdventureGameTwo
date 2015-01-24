using UnityEngine;
using System.Collections;

public class Charactercontroller : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.W)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);

			transform.Translate(new Vector3(0,5,0) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.S)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);
			
			transform.Translate(new Vector3(0,-5,0) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.A)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);
			
			transform.Translate(new Vector3(-5,0,0) * Time.deltaTime);
		}
		if (Input.GetKey(KeyCode.D)){
			//transform.position = new Vector2(transform.position.y, transform.transform.position.y +1);
			
			transform.Translate(new Vector3(5,0,0) * Time.deltaTime);
		}
	
	}

	void OnTriggerEnter2D(Collider2D other){

		if (other.tag == "wall"){
			Destroy(other.gameObject, 0);
		}
	}
}
