using UnityEngine;
using System.Collections;
using UnityEngine .UI;

public class PlaceChallenge : MonoBehaviour {
	
	public Text pleasure;
	public Text phrase;

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Pleasure(string texto)
	{
		pleasure.text = texto;
	}

	public void Phrase(string texto)
	{
		phrase .text = texto;
	}

}
