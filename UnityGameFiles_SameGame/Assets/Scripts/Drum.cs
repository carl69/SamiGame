using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using XInputDotNetPure; // Required in C#

public class Drum : MonoBehaviour
{
    public int countX;
    public int countY;
    private bool X_isAxisInUse = false;
    private bool Y_isAxisInUse = false;

    public GameObject GC;


    GamePadState state;
    public GameObject rightSection;
    public GameObject leftSection;
    public GameObject upSection;
    public GameObject downSection;
    
    private int stringFormerLength;

    public string noaidiSpeak;
    public string spiritServants;

    public string noadiFromSpirit;
    public string noadiToSpirit;
    private bool commandIssued;

    private AudioSource audioSource;
    public AudioClip drumSound;

    public AudioClip[] drumList;
    public AudioClip[] drumComandos;

    public GameObject bearSpirit;
    // Use this for initialization
    void Start()
    {
        //Basic servants: Loddi=bird Boazu=reindeer Guolli=fish 
        //Advanced: Gouvza=bear Gearpmas=snake Voukhu=Bird, but for evil purposes Juovssaheaddji=helper to fight evil and thieves
        //Other: Noaidegazzi=deaceased familly or another noaide Snollagazzi=spirit with responsible for the sami peoples sexuality
        spiritServants += "Loddi Gouvza";

        audioSource = gameObject.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(stringFormerLength < noaidiSpeak.Length && commandIssued==false) { drumBeatStandard(); }
        else if (commandIssued == true)
        {
            drumBeatFinish();
        }

        if (Input.GetAxisRaw("DpadX") != 0)
        {
            if (X_isAxisInUse == false)
            {
                if (Input.GetAxisRaw("DpadX") == +1)
                {countX += 1;}
                else if (Input.GetAxisRaw("DpadX") == -1)
                {
                    countX -= 1;
                }
                X_isAxisInUse = true;
            }

        }
        else
        {
            countX = 0;
        }
        if (Input.GetAxisRaw("DpadX") == 0)
        {
            X_isAxisInUse = false;
        }
        //----------------------------------------
        if (Input.GetAxisRaw("DpadY") != 0)
        {
            if (Y_isAxisInUse == false)
            {
                if (Input.GetAxisRaw("DpadY") == +1)
                {
                    countY += 1;
                }
                else if (Input.GetAxisRaw("DpadY") == -1)
                {
                    countY -= 1;
                }
                Y_isAxisInUse = true;
            }
        }
        else
        {
            countY = 0;
        }
        if (Input.GetAxisRaw("DpadY") == 0)
        {
            Y_isAxisInUse = false;
        }

        DrumComands();

        playDrum();
    }
    void playDrum()
    {
        if (Input.GetKey("1") || countX == -1)
        {
            leftSection.SetActive(true);
            if (Input.GetKeyDown("q") || Input.GetButtonDown("XButton"))
            {
                noaidiSpeak += "LX";
            }
            else if (Input.GetKeyDown("w") || Input.GetButtonDown("YButton"))
            {
                noaidiSpeak += "LY";
            }
            else if (Input.GetKeyDown("e") || Input.GetButtonDown("BButton"))
            {
                noaidiSpeak += "LB";
            }
            else if (Input.GetKeyDown("r") || Input.GetButtonDown("AButton"))
            {
                noaidiSpeak += "LA";
            }
        }
        else { leftSection.SetActive(false); }


        if (Input.GetKey("2") || countY == 1)
        {
            upSection.SetActive(true);
            if (Input.GetKeyDown("q") || Input.GetButtonDown("XButton"))
            {
                noaidiSpeak += "UX";
            }
            else if (Input.GetKeyDown("w") || Input.GetButtonDown("YButton"))
            {
                noaidiSpeak += "UY";
            }
            else if (Input.GetKeyDown("e") || Input.GetButtonDown("BButton"))
            {
                noaidiSpeak += "UB";
            }
            else if (Input.GetKeyDown("r") || Input.GetButtonDown("AButton"))
            {
                noaidiSpeak += "UA";
            }
        }
        else { upSection.SetActive(false); }

        if (Input.GetKey("3") || countX == 1)
        {
            rightSection.SetActive(true);
            if (Input.GetKey("q") || Input.GetButtonDown("XButton"))
            {
                noaidiSpeak += "RX";
            }
            else if (Input.GetKeyDown("w") || Input.GetButtonDown("YButton"))
            {
                noaidiSpeak += "RY";
            }
            else if (Input.GetKeyDown("e") || Input.GetButtonDown("BButton"))
            {
                noaidiSpeak += "RB";
            }
            else if (Input.GetKeyDown("r") || Input.GetButtonDown("AButton"))
            {
                noaidiSpeak += "RA";
            }
        }
        else { rightSection.SetActive(false); }

        if (Input.GetKey("4") || countY == -1)
        {
            downSection.SetActive(true);
            if (Input.GetKeyDown("q") || Input.GetButtonDown("XButton"))
            {
                noaidiSpeak += "DX";
            }
            else if (Input.GetKeyDown("w") || Input.GetButtonDown("YButton"))
            {
                noaidiSpeak += "DY";
            }
            else if (Input.GetKeyDown("e") || Input.GetButtonDown("BButton"))
            {
                noaidiSpeak += "DB";
            }
            else if (Input.GetKeyDown("r") || Input.GetButtonDown("AButton"))
            {
                noaidiSpeak += "DA";
            }
        }
        else { downSection.SetActive(false); }
    }
    void DrumComands()
    {
        if (spiritServants.Contains("Loddi"))
        {
            if (noaidiSpeak.EndsWith("LXRARB"))
            {
                //this strarts the trance and let the soul leave the body
                print("Need beg you to now begin the journey!");
                //GC.GetComponent<gameController>().saivu = true;
                drumBeatFinish();
                GC.GetComponent<gameController>().trance();
                noaidiSpeak += " ";
            }
            if (noaidiSpeak.EndsWith("RBRALX"))
            {
                //this returns the soul to the body
                print("You renter your body");
                drumBeatFinish();
                GC.GetComponent<gameController>().EndTrance();
                noaidiSpeak += " ";
            }
        }
        if (spiritServants.Contains("Boazu"))
        {
            if (noaidiSpeak.EndsWith("UADXRY"))
            {
                print("You healed this guy");
            }

            if (noaidiSpeak.EndsWith("1Q3Q"))
            {
                print("there is a flock of reindeers to the south, grassing the valley.");
            }
            if (noaidiSpeak.EndsWith("2R4R3R1Q1Q1Q1W"))
            {
                print("This will be a cold winter. Stock up food or half of you will join us before the first leaf spring");
            }
            if (noaidiSpeak.Contains("1Q2W3E4R"))
            {
                print("I am here to help");
            }
        }
        if (spiritServants.Contains("Gouvza"))
        {
            if (noaidiSpeak.EndsWith("LYLYLYLY"))
            {
                print("Who do you want us to get rid off?!");
                bearSpirit.SetActive(true);
                noaidiSpeak += " ";
            }
            if (noaidiSpeak.EndsWith("LYLYLYRB"))
            {
                print("Was that all?! I will go back to sleep now...");
                bearSpirit.SetActive(true);
                noaidiSpeak += " ";
            }
        }
    }
    void drumBeatStandard()
    {
        int index = Random.Range(0, drumList.Length);
        drumSound = drumList[index];
        audioSource.clip = drumSound;
        audioSource.Play();

        stringFormerLength = noaidiSpeak.Length;
    }
    void drumBeatFinish()
    {
        int index = Random.Range(0, drumComandos.Length);
        drumSound = drumComandos[index];
        audioSource.clip = drumSound;
        audioSource.Play();

        stringFormerLength = noaidiSpeak.Length;
        commandIssued = false;
        print("bam");
    }

}