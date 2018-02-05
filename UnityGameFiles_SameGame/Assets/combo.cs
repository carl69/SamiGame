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
			Debug.Log("button 1 pressed");

		}
		if (box.name == "Button2")
		{
			Debug.Log("button 2 pressed");

		}
		if (box.name == "Button3")
		{
			Debug.Log("button 3 pressed");

		}
		if (box.name == "Button4")
		{
			Debug.Log("button 4 pressed");

		}
		if (box.name == "Button5")
		{
			Debug.Log("button 5 pressed");

		}
		if (box.name == "Button6")
		{
			Debug.Log("button 6 pressed");

		}
		if (box.name == "Button7")
		{
			Debug.Log("button 7 pressed");

		}
		if (box.name == "Button8")
		{
			Debug.Log("button 8 pressed");

		}
		if (box.name == "Button9")
		{
			Debug.Log("button 9 pressed");

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
