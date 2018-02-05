using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
    public Color defultColour;
    public Color selectedColour;
    private Material mat;
	GameObject box_manager;
	combo Combo;

<<<<<<< HEAD
    public string sendToNaidiSpeak;
    public GameObject drum;
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }
=======

	private void Start()
	{
		mat = GetComponent<Renderer>().material;
		box_manager = GameObject.Find("box_manager");
		Combo = box_manager.GetComponent<combo>();
	}

	public void Update()
	{
>>>>>>> 0fde01cd5e6559cf7a60b8368be5ae362ee56664

	}


	void OnTouchDown()
    {
        mat.color = selectedColour;
        print("Down");
<<<<<<< HEAD
        drum.GetComponent<Drum>().noaidiSpeak += sendToNaidiSpeak;
=======
		Combo.SendMessage("boxHit", this.gameObject, SendMessageOptions.DontRequireReceiver);
>>>>>>> 0fde01cd5e6559cf7a60b8368be5ae362ee56664
    }

	//void OnTouchUp()
	//{
	//	mat.color = defultColour;
	//	print("Up");
	//}

	void OnTouchStay()
    {
        mat.color = selectedColour;
        print("Staying");
    }

    void OnTouchExit()
    {
        mat.color = defultColour;
        print("Exit");
    }
}
