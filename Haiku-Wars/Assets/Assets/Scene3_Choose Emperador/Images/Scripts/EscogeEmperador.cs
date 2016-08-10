using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class EscogeEmperador : MonoBehaviour {

	public Image [] backOfCards= new Image[4] ;
	public List<Sprite> cardsOfEmperor = new List<Sprite>();

	public Button goButton;

	void Awake()
	{
		goButton.gameObject.SetActive(false);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cardsOfEmperor.Count <= 0)
			goButton.gameObject.SetActive(true);
	}

	public void ChooseEmperor(int numberOfCard)
	{		
		if (cardsOfEmperor.Count > 0) {
			int random = Random.Range (0, cardsOfEmperor.Count);
			backOfCards [numberOfCard].sprite = cardsOfEmperor [random];
			cardsOfEmperor.RemoveAt (random);	
		}
	}

	public void FirstCard()
	{
		ChooseEmperor(0);
	}

	public void SecondCard()
	{
		ChooseEmperor( 1);
	}

	public void ThirdCard()
	{
		ChooseEmperor( 2);
	}

	public void FourthCard()
	{
		ChooseEmperor(3);
	}
}
