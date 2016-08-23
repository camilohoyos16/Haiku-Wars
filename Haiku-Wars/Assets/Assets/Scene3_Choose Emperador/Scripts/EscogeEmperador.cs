using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using System.Collections.Generic;

public class EscogeEmperador : MonoBehaviour {

	public Image [] backOfCards= new Image[4] ;
	public List<Sprite> cardsOfEmperor = new List<Sprite>();
	public Button [] buttons= new Button[4] ;
	private OrganizeTurns organizeturns;
	public Button goButton;

	void Awake()
	{
		goButton.gameObject.SetActive(false);
	}

	void Start () {
		organizeturns  = OrganizeTurns .FindObjectOfType<OrganizeTurns>() ;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (cardsOfEmperor.Count <= 0) {
			//organizeturns.AdministerTurns ();
			organizeturns.AdministerTurns ();
			goButton.gameObject.SetActive (true);
		}
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
		buttons [0].gameObject.SetActive (false);
	}

	public void SecondCard()
	{
		ChooseEmperor( 1);
		buttons [1].gameObject.SetActive (false);
	}

	public void ThirdCard()
	{
		ChooseEmperor( 2);
		buttons [2].gameObject.SetActive (false);
	}

	public void FourthCard()
	{
		ChooseEmperor(3);
		buttons [3].gameObject.SetActive (false);
	}
}
