using UnityEngine;
using System.Collections;
using UnityEngine .UI;

public class PlaceChallenge : MonoBehaviour {
	
	public Text pleasure;
	public Text phrase;

	public string pleasureText;
	public string phraseText;
	public static PlaceChallenge instance=null;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);  
		
		DontDestroyOnLoad (this.gameObject);
	}

	void Start () {
		/*pleasure  = GameObject.Find ("Pleasure").GetComponent<Text> (); 
		phrase = GameObject.Find ("Phrase").GetComponent <Text> ();*/
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void FindThings()
	{
		pleasure  = GameObject.Find ("Pleasure").GetComponent<Text> (); 
		phrase = GameObject.Find ("Phrase").GetComponent <Text> ();
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
