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
				Color color = Color.HSVToRGB (0, 225, 227,true);
				turnoDe.color = color;
				break;
			case "YellowEmperor":
				showFace.sprite = faces [1];
				Color color1 = Color.HSVToRGB (47, 255, 243,true);
				turnoDe.color = color1;
				break;
			case "BlueEmperor":
				showFace.sprite = faces [2];
				Color color2 = Color.HSVToRGB (225, 164, 170,true);
				turnoDe.color = color2;
				break;
			case "WhiteEmperor":
				showFace.sprite = faces [3];
				Color color3 = Color.HSVToRGB (60, 68, 256,true );
				turnoDe.color = color3;
				break;
			default :
				break;
			}
		}
	}
}
