using UnityEngine;
using System.Collections;
using UnityEngine .UI;
using UnityEngine .SceneManagement ;

public class TurnEveryScene : MonoBehaviour {

	public  Sprite [] faces= new Sprite[4]; 
	public SpriteRenderer showFace;
	public Image turnoDe;

	public static TurnEveryScene instance=null ;

	void Awake()
	{
		if (!instance)
			instance = this;
		else
			Destroy (gameObject);
		
		DontDestroyOnLoad (this.gameObject);
	}

	void Start () {
	}

	public void FindElements()
	{
		showFace = GameObject.Find ("FaceTurn").GetComponent <SpriteRenderer >();
		turnoDe = GameObject.Find ("ColorTurn").GetComponent <Image> ();
	}
	
	// Update is called once per frame
	void Update () {
		if(SceneManager .GetActiveScene().name.Equals ( "4_Select Phrase" )|| SceneManager .GetActiveScene().name.Equals ("5_Select Pleasure"))
		{
			switch (OrganizeTurns.emperorsOrderTurn[0].name) 
			{
			case "RedEmperor":
				showFace.sprite = faces [0];
				Color color = Color.red;
				color.a = 0.7f;
				turnoDe.color = color;
				break;
			case "YellowEmperor":
				showFace.sprite = faces [1];
				Color color1 = Color.yellow;
				color1.a = 0.7f;
				turnoDe.color = color1;
				break;
			case "BlueEmperor":
				showFace.sprite = faces [2];
				Color color2 = Color.blue;
				color2.a = 0.7f;
				turnoDe.color = color2;
				break;
			case "WhiteEmperor":
				showFace.sprite = faces [3];
				Color color3 = Color.white;
				color3.a = 0.7f;
				turnoDe.color = color3;
				break;
			default :
				break;
			}
		}
	}
}
