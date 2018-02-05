using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gameController : MonoBehaviour {
    public GameObject DrumObject;
    private bool drumActive;

    public GameObject activePlayer;
    public GameObject playerMW;
    public GameObject playerSW;
    private Camera camera;

    public bool saivu;
    public Material overworldSkybox;
    public Material spiritWorldSkybox;
    private GameObject dialogueManager;
    GameObject materialSurroundings;
    GameObject spiritSurroundings;
    //public PlayerMovement PlayerMovement;
    // Use this for initialization

    private void Awake()
    {
        playerMW = GameObject.Find("BodySpirit");
        playerSW = GameObject.Find("/FreeSpirit");
        saivu = false;

        camera = Camera.main;
        dialogueManager = GameObject.Find("/GameController/DialogueManager");
        playerSW.SetActive(false);
        activePlayer = playerMW;
        materialSurroundings =GameObject.Find("MaterialSurroundings");
        spiritSurroundings = GameObject.Find("SpiritSurroundings");

    }
    void Start () {

    }
	
	// Update is called once per frame
	void Update () {
        if (Input.GetButtonDown("LTrigger"))
        {
            if (drumActive == true)
            {
                drumActive = false;
                DrumObject.SetActive(false);
            }
            else if (drumActive == false)
            {
                drumActive = true;
                DrumObject.SetActive(true);
            }
        }
        //for when you enter the spirit world, Saivu
        if (saivu == true)
        {
            RenderSettings.skybox = spiritWorldSkybox;
            spiritSurroundings.SetActive(true);
            materialSurroundings.SetActive(false);
        }
        else
        {
            RenderSettings.skybox = overworldSkybox;
            spiritSurroundings.SetActive(false);
            materialSurroundings.SetActive(true);
        }
    }
    public void trance()
    {
        saivu = true;
        activePlayer = playerSW;

        playerMW.GetComponent<PlayerMovement>().enabled = false;

        playerSW.transform.position = playerMW.transform.position;
        playerSW.SetActive(true);
    }
    public void EndTrance()
    {
        saivu = false;
        activePlayer = playerMW;
        playerMW.GetComponent<PlayerMovement>().enabled = true;
        playerSW.SetActive(false);
    }
}
