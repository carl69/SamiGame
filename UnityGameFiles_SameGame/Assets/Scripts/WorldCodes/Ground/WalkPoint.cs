using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkPoint : MonoBehaviour {
    GameObject Player;
    PlayerMovementTouch PMovement;
	// Use this for initialization
	void Start () {
        Player = GameObject.FindGameObjectWithTag("Player");
        if (Player != null)
        {
            PMovement = Player.GetComponent<PlayerMovementTouch>();

        }
        else
        {
            Debug.LogError("NO PLAYER PREFAB");
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}


    void OnTouchStay(Vector3 point)
    {
        PMovement.SendMessage("OnMove",point,SendMessageOptions.DontRequireReceiver);
    }
}
