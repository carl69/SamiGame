using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class button : MonoBehaviour {
    public Color defultColour;
    public Color selectedColour;
    private Material mat;

    public string sendToNaidiSpeak;
    public GameObject drum;
    private void Start()
    {
        mat = GetComponent<Renderer>().material;
    }



    void OnTouchDown()
    {
        mat.color = selectedColour;
        print("Down");
        drum.GetComponent<Drum>().noaidiSpeak += sendToNaidiSpeak;
    }

    void OnTouchUp()
    {
        mat.color = defultColour;
        print("Up");
    }

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
