using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DialogueManager : MonoBehaviour {

	public Text nameText;
	public Text dialogueText;

	public Animator animator;
    public GameObject player;
    public GameObject nextButton;
	private Queue<string> sentences;
    public bool talking;

	// Use this for initialization
	void Start () {
        //player = GameObject.Find("GameController").GetComponent<gameController>().activePlayer;
        sentences = new Queue<string>();
	}
    private void Update()
    {
        //player = GameObject.Find("GameController").GetComponent<gameController>().activePlayer;
    }
    public void StartDialogue (Dialogue dialogue)
	{
		animator.SetBool("IsOpen", true);

		nameText.text = dialogue.name;

		sentences.Clear();

		foreach (string sentence in dialogue.sentences)
		{
			sentences.Enqueue(sentence);
		}

		DisplayNextSentence();
	}

	public void DisplayNextSentence ()
	{
		if (sentences.Count == 0)
		{
			EndDialogue();
			return;
		}

		string sentence = sentences.Dequeue();
		StopAllCoroutines();
		StartCoroutine(TypeSentence(sentence));
	}

	IEnumerator TypeSentence (string sentence)
	{
		dialogueText.text = "";
		foreach (char letter in sentence.ToCharArray())
		{
			dialogueText.text += letter;
			yield return null;
		}
	}

	void EndDialogue()
	{
        talking = false;
        print("ending all talks");
		animator.SetBool("IsOpen", false);
	}

}
