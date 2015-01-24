using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
	private bool Machete;
	private bool Tourch;
	public GUIText inventoryText;


	void Start()
	{
		Tourch = false;
		Machete = false;

		inventoryText.text = "Inventory: ";
	}
	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.tag == "Machete")
		{
			Machete = true;
			Destroy(other.gameObject);
			inventoryText.text += "Machete ";
		}

		if(other.tag == "Tourch")
		{
			Tourch = true;
			Destroy(other.gameObject);
			inventoryText.text += "Tourch ";
		}
	}
}
