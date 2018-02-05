using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

	public GameObject[] Boxes;

	// Update is called once per frame
	void Update () {
		
	}

	void boxHit(GameObject box)
	{
		Debug.Log("ass" + box);
		if (box.name == "Button1") 
		{
			print ("1");
		}
		if (box.name == "Button2")
		{
			print ("2");
		}
		if (box.name == "Button3")
		{
			print ("3");
		}
		if (box.name == "Button4")
		{
			print ("4");
		}
		if (box.name == "Button5")
		{
			print ("5");
		}
		if (box.name == "Button6")
		{
			print ("6");
		}
		if (box.name == "Button7")
		{
			print ("7");
		}
		if (box.name == "Button8")
		{
			print ("81");
		}
		if (box.name == "Button9")
		{
			print ("9");
		}
	}

	//void Victory()
	//{
	//	if (string s == "357")
	//	{
	//		Debug.Log("Voctory!");
	//	}
	//}

}
