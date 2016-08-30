using UnityEngine;
using System.Collections;
using UnityEngine .UI;

public class ChoosePleasure : MonoBehaviour {

	public Text pleasure;


	public string pleasureText;

	public static ChoosePleasure instance=null;

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
		pleasure  = GameObject.Find ("Pleasure").GetComponent<Text> (); 
	}

	public void Pleasure(string texto)
	{		
		pleasure.text = texto;
		pleasureText = pleasure.text;	
	}
}
