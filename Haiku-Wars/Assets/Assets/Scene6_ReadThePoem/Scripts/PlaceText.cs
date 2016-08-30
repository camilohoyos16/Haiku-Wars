using UnityEngine;
using System.Collections;
using UnityEngine .UI;
public class PlaceText : MonoBehaviour {

	public Text phrase;
	public Text pleasure;

	private ChoosePhrase takePhraseText;
	private ChoosePleasure takePleasureText;

	void Awake()
	{
		takePhraseText = ChoosePhrase.FindObjectOfType<ChoosePhrase> ();
		takePleasureText = ChoosePleasure.FindObjectOfType <ChoosePleasure > ();

		phrase  = GameObject.Find ("Phrase").GetComponent <Text> ();
		pleasure  = GameObject.Find ("Pleasure").GetComponent <Text> ();
	}

	void Start () {
		phrase.text = takePhraseText.phraseText;
		pleasure.text = takePleasureText.pleasureText;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
