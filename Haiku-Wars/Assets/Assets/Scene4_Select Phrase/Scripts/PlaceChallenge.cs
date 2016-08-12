using UnityEngine;
using System.Collections;
using UnityEngine .UI;

public class PlaceChallenge : MonoBehaviour {
	
	public Text pleasure;
	public Text phrase;

	public string pleasureText;
	public string phraseText;

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pleasure(string texto)
	{		
		pleasure.text = texto;
		pleasureText = pleasure.text;
		//DontDestroyOnLoad (pleasureText as GameObject);
	}

	public void Phrase(string texto)
	{
		phrase .text = texto;
		phraseText = phrase.text;
		//DontDestroyOnLoad (phraseText as GameObject);
	}

}
