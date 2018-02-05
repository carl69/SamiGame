using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkPoint : MonoBehaviour {
    GameObject Player;
    PlayerMovement PMovement;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        PMovement = Player.GetComponent<PlayerMovement>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTouchStay(Vector3 point)
    {
        
        Debug.Log(point);
    }
}
