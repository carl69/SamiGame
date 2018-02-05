using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combo : MonoBehaviour {
	public string Victory;
	// Use this for initialization
	void Start () {
		
	}

	public GameObject[] Boxes;

	// Update is called once per frame
	void Update () {
		if (Victory.EndsWith("12 3 12 "))
		{
			print("Voctory!");
		}
	}

	void boxHit(GameObject box)
	{
		Debug.Log("ass" + box);
		if (box.name == "Button1") 
		{
			Victory += "1 ";
			print ("1");
		}
		if (box.name == "Button2")
		{
			Victory += "2 ";
			print ("2");
		}
		if (box.name == "Button3")
		{
			Victory += "3 ";
			print ("3");
		}
		if (box.name == "Button4")
		{
			Victory += "4 ";
			print ("4");
		}
		if (box.name == "Button5")
		{
			Victory += "5 ";
			print ("5");
		}
		if (box.name == "Button6")
		{
			Victory += "6 ";
			print ("6");
		}
		if (box.name == "Button7")
		{
			Victory += "7 ";
			print ("7");
		}
		if (box.name == "Button8")
		{
			Victory += "8 ";
			print ("8");
		}
		if (box.name == "Button9")
		{
			Victory += "9 ";
			print ("9");
		}
		if (box.name == "Button10")
		{
			Victory += "10 ";
			print("10");
		}
		if (box.name == "Button11")
		{
			Victory += "11 ";
			print("11");
		}
		if (box.name == "Button12")
		{
			Victory += "12 ";
			print("12");
		}
		if (box.name == "Button13")
		{
			Victory += "13 ";
			print("13");
		}
		if (box.name == "Button14")
		{
			Victory += "14 ";
			print("14");
		}
	}

	

}
