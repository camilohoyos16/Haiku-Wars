using UnityEngine;
using System.Collections;
using UnityEngine .UI ;

public class GetTextOfButtonsPleasure : MonoBehaviour {

	private  Text text;
	//private PlaceChallenge placeChallenge;
	// Use this for initialization
	void Awake()
	{
		text = GetComponent <Text > ();

	}

	void Start () {
		//placeChallenge = PlaceChallenge.FindObjectOfType<PlaceChallenge >() ;
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void OnClick()
	{
		SendText ();
	}

	public void SendText()
	{
		PlaceChallenge .instance.Pleasure(text.text);
	}
}
