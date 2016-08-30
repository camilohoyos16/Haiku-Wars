using UnityEngine;
using System.Collections;
using UnityEngine .UI;

public class ChoosePhrase : MonoBehaviour {
	
	public Text phrase;

	public string phraseText;
	public static ChoosePhrase instance=null;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);  
		
		DontDestroyOnLoad (this.gameObject);
	}

	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FindThings()
	{
		phrase = GameObject.Find ("Phrase").GetComponent <Text> ();
	}

	public void Phrase(string texto)
	{
		phrase .text = texto;
		phraseText = phrase.text;
	}
}
