﻿using UnityEngine;
using System.Collections;

public class PickUp : MonoBehaviour 
{
	public GUIText invText;
	private bool Tourch;
	private bool Machete;
	private bool Ladder;
	private bool Planks;

	void Start()
	{
		Tourch = false;
		Machete = false;
		Ladder = false;
		Planks = false;

		invText.text = "Inventory: ";
	}

	void OnTriggerEnter2D(Collider2D other)
	{
		if(Tourch == false)
		{
			if(other.tag == "Tourch")
			{
				Tourch = true;
				invText.text += "Tourch ";
				Destroy(other.gameObject);
			}
		}

		if(Machete == false)
		{
			if(other.tag == "Machete")
			{
				Machete = true;
				invText.text += "Machete ";
				Destroy(other.gameObject);
			}
		}

		if(Ladder == false)
		{
			if(other.tag == "Ladder")
			{
				Ladder = true;
				invText.text += "Ladder ";
				Destroy(other.gameObject);
			}
		}

		if(Planks == false)
		{
			if(other.tag == "Planks")
			{
				Planks = true;
				invText.text += "Planks ";
				Destroy(other.gameObject);
			}
		}
	}
	bool CheckMachete()
	{
		if(Machete == true)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	bool CheckLadder()
	{
		if(Ladder == true)
		{
			return Ladder;
		}
		else
		{
			return false;
		}
	}

	bool CheckPlanks()
	{
		if(Machete == true)
		{
			return true;
		}
		else
		{
			return false;
		}
	}

	bool CheckTourch()
	{
		if(Machete == true)
		{
			return true;
		}
		else
		{
			return false;
		}
	}
}
