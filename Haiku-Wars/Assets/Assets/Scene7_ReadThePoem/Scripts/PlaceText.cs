using UnityEngine;
using System.Collections;
using UnityEngine .UI;
public class PlaceText : MonoBehaviour {

	public Text Phrase;
	public Text Pleasure;

	private PlaceChallenge takeTexts;

	void Awake()
	{
		takeTexts = PlaceChallenge.FindObjectOfType<PlaceChallenge> ();
	}

	void Start () {
		Phrase.text = takeTexts.phraseText;
		Pleasure.text = takeTexts.pleasureText;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
