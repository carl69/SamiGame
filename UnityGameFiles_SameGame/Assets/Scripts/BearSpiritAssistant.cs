using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BearSpiritAssistant : MonoBehaviour {
    public int health;
	// Use this for initialization
	void Start () {
        health = 10000;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        health -= 1;
        if (health <= 0)
        {
            gameObject.SetActive(false);
        }
	}
   void OnTriggerStay(Collider other)
    {
        if (other.tag == "NPC")
        {
            if (Input.GetButtonDown("XButton"))
            {
                
                other.GetComponent<Health>().hp -= 5;
            }
        }
        if (other.tag == "SpiritNPC")
        {
            if (Input.GetButtonDown("XButton"))
            {

                other.GetComponent<Health>().hp -= 10;
            }
        }
    }
}
