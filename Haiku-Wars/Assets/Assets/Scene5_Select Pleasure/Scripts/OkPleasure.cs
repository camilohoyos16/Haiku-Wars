using UnityEngine;
using System.Collections;
using UnityEngine .UI ;
using UnityEngine.SceneManagement;

public class OkPleasure : MonoBehaviour {

	public Text text;
	public Button buton;
	public Text buttonText;


	private ChoosePleasure placeChallenge;
	private AudioSource hai;

	void Awake()
	{		
		placeChallenge = ChoosePleasure.FindObjectOfType <ChoosePleasure > ();
		text = GameObject.Find ("Pleasure").GetComponent<Text> (); 
		buton = GameObject.Find ("OkButton").GetComponent <Button >();
		buttonText = GameObject.Find ("ButtonText").GetComponent <Text> ();
		buton.interactable = false;
		Color colorText = buttonText .color;
		colorText.a = 0.5f;
		buttonText .color = colorText;

		hai = GetComponent <AudioSource> ();
	}

	void Start () {
		placeChallenge.FindThings ();
	}

	void Update () {

		if (text.text.Length > 0) {
			buton.interactable = true;
			Color colorText = buttonText .color;
			colorText.a = 1f;
			buttonText .color = colorText;
		}
	}

	public void ChanceScene()
	{
		hai.Play ();
		StartCoroutine (NextScene ());
	}

	IEnumerator NextScene()
	{
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("6_ReadThePoem");
	}
}
