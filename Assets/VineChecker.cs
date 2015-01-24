using UnityEngine;
using System.Collections;

public class VineChecker : MonoBehaviour {
	public bool IsTouching = false;
	Collider2D lastTouched;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerExit2D(Collider2D other){
		if (other.tag == "vine") {
			IsTouching = false;
		}
	}
	void OnTriggerEnter2D(Collider2D other){
		if (other.tag == "vine") {
			lastTouched = other;
			IsTouching = true;
		}
		
	}
	public void CheckVine(){
		if (IsTouching){
			Destroy(lastTouched.gameObject);
			IsTouching = false;
			lastTouched = null;
		}
	}
}
