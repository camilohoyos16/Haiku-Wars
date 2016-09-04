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

	public Text goText;

	private AudioSource audio;

	void Awake()
	{		
		goButton.interactable =false;
		Color colorText = goText.color;
		colorText.a = 0.5f;
		goText.color = colorText;
		audio = GetComponent<AudioSource > ();
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
			goButton.interactable =true;
			Color colorText = goText.color;
			colorText.a = 1f;
			goText.color = colorText;
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
		audio.Play();
	}

	public void SecondCard()
	{
		ChooseEmperor( 1);
		buttons [1].gameObject.SetActive (false);
		audio.Play();
	}

	public void ThirdCard()
	{
		ChooseEmperor( 2);
		buttons [2].gameObject.SetActive (false);
		audio.Play();
	}

	public void FourthCard()
	{
		ChooseEmperor(3);
		buttons [3].gameObject.SetActive (false);
		audio.Play();
	}
}
