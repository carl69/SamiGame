using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class NPC_Change_Colour : MonoBehaviour {

    public void TouchOn()
    {
        print("Something");
        GetComponentInChildren<SpriteRenderer>().color = Color.red;
    }
}
