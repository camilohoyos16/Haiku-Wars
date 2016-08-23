using UnityEngine;
using System.Collections;
using UnityEngine .UI ;
using UnityEngine.SceneManagement;

public class OkPhrase : MonoBehaviour {
	public Text text1;
	public Text text2;
	public Button buton;

	private bool activeScene = true;

	private PlaceChallenge placeChallenge;

	void Awake()
	{		
		placeChallenge = PlaceChallenge.FindObjectOfType <PlaceChallenge > ();
		text1 = GameObject.Find ("Pleasure").GetComponent<Text> (); 
		text2 = GameObject.Find ("Phrase").GetComponent <Text> ();
		buton = GameObject.Find ("OkButton").GetComponent <Button >();
		buton.gameObject.SetActive (false);
	}

	void Start () {
		placeChallenge.FindThings ();
	}

	void Update () {
		
		if (text1.text.Length >0 && text2.text.Length >0)
			buton.gameObject.SetActive (true);
	}

	public void ChanceScene()
	{
		SceneManager.LoadScene ("7_ReadThePoem");
	}

}
