using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour
{
    public Color defultColour;
    public Color selectedColour;
    private Material mat;
    GameObject box_manager;
    combo Combo;


    public string sendToNaidiSpeak;
    public GameObject drum;

    private void Start()
    {
        mat = GetComponent<Renderer>().material;
        box_manager = GameObject.Find("box_manager");
        Combo = box_manager.GetComponent<combo>();
    }

    public void Update()
    {

    }


    void OnTouchDown()
    {
        drum.GetComponent<Drum>().noaidiSpeak += sendToNaidiSpeak;
        mat.color = selectedColour;
        print("Down");
        Combo.SendMessage("boxHit", this.gameObject, SendMessageOptions.DontRequireReceiver);
    }

    //void OnTouchUp()
    //{
    //    mat.color = defultColour;
    //    print("Up");
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