﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SpiritMovement : MonoBehaviour
{
    public Text interactText;
    public GameObject interactInterface;
    public float speed;
    //public bool talking;

    private Rigidbody rb;
    private GameObject GC;
    private GameObject DM;

    private void Awake()
    {
        //DM = GameObject.Find("DialogueManager");
    }
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        DM = GameObject.Find("DialogueManager");
        GC = GameObject.Find("GameController");
    }

    void FixedUpdate()
    {
       // GC.GetComponent<gameController>().talking;
        if (DM.GetComponent<DialogueManager>().talking == false)
        {
            //stops movement
            if (0 == Input.GetAxis("Vertical") && 0 == Input.GetAxis("Horizontal"))
            {
                rb.velocity = Vector3.zero;
                rb.angularVelocity = Vector3.zero;
            }
            //these things add force
            else
            {
                transform.Translate(Vector3.right * Time.deltaTime * speed * Input.GetAxis("Horizontal"));
                transform.Translate(Vector3.forward * Time.deltaTime * speed * Input.GetAxis("Vertical"));

                //Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

                //rb.AddForce(movement * speed);
            }
        }
    }
    void OnTriggerStay(Collider other)
    {
        if (other.tag == "SpiritNPC")
        {
            interactText.text = "Talk to the spirit";
            interactInterface.SetActive(true);
            if (Input.GetButtonDown("AButton") && DM.GetComponent<DialogueManager>().talking == false)
            {
                other.GetComponent<DialogueTrigger>().TriggerDialogue();
                DM.GetComponent<DialogueManager>().talking = true;
            }
        }
        //spirits do not talk to NPCs they can hovewer talk to "SpiritNPC"s

        /*if(other.tag == "NPC")
        {
            interactText.text = "Talk";
            interactInterface.SetActive(true);

            //to start a dialogue
            if (Input.GetButtonDown("AButton") && DM.GetComponent<DialogueManager>().talking == false)
            {
                other.GetComponent<DialogueTrigger>().TriggerDialogue();
                DM.GetComponent<DialogueManager>().talking = true;
            }
        }*/
        if (other.tag == "Seidi")
        {
            interactText.text = "Make an offering";
            interactInterface.SetActive(true);

            //to start a dialogue
            if (Input.GetButtonDown("AButton") && DM.GetComponent<DialogueManager>().talking == false)
            {
                other.GetComponent<DialogueTrigger>().TriggerDialogue();
                DM.GetComponent<DialogueManager>().talking = true;
            }
        }
        if (other.name == "BodySpirit")
        {
            print("want to enter body");
            interactText.text = "Re-enter body";
            interactInterface.SetActive(true);
            if (Input.GetButtonDown("AButton") && DM.GetComponent<DialogueManager>().talking == false)
            {
                other.GetComponent<DialogueTrigger>().TriggerDialogue();
                DM.GetComponent<DialogueManager>().talking = true;
                GC.GetComponent<gameController>().EndTrance();
            }
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other)
        {
            interactInterface.SetActive(false);
        }
    }
}