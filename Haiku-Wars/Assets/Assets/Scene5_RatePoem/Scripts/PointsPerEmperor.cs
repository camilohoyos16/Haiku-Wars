using UnityEngine;
using System.Collections;
using UnityEngine .UI ;
using UnityEngine .SceneManagement ;


public class PointsPerEmperor : MonoBehaviour {
	
	public int bluePoints;
	public int yellowPoints;
	public int redPoints;
	public int whitePoints;

	public Text points1Text;
	public Text points2Text;
	public Text points3Text;

	public static PointsPerEmperor instance = null;

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);  
		
		DontDestroyOnLoad (this.gameObject);
	}

	public void FindThings()
	{
		points1Text = GameObject.Find ("Points1").GetComponent <Text> ();
		points2Text = GameObject.Find ("Points2").GetComponent <Text> ();
		points3Text = GameObject.Find ("Points3").GetComponent <Text> ();
	}

	void Start () {
		Debug .Log (OrganizeTurns.emperorsOrderTurn [0].name);
	}	

	void Update () {
		
	}



	public void AssignPoints()
	{
		for (int i = 1; i < 4; i++) {
			if (i == 1) {
				switch (OrganizeTurns.emperorsOrderTurn [i].name) {
				case "BlueEmperor":
					bluePoints += int.Parse (points1Text.text);
					break;
				case "YellowEmperor":
					yellowPoints += int.Parse (points1Text.text);
					break;
				case "WhiteEmperor":
					whitePoints += int.Parse (points1Text.text);
					break;
				case "RedEmperor":
					redPoints += int.Parse (points1Text.text);
					break;
				default :
					break;
				}
			}
			if (i == 2) {
				switch (OrganizeTurns.emperorsOrderTurn [i].name) {
				case "BlueEmperor":
					bluePoints += int.Parse (points2Text.text);
					break;
				case "YellowEmperor":
					yellowPoints += int.Parse (points2Text.text);
					break;
				case "WhiteEmperor":
					whitePoints += int.Parse (points2Text.text);
					break;
				case "RedEmperor":
					redPoints += int.Parse (points2Text.text);
					break;
				default :
					break;
				}
			}
			if (i == 3) {
				switch (OrganizeTurns.emperorsOrderTurn [i].name) {
				case "BlueEmperor":
					bluePoints += int.Parse (points3Text.text);
					break;
				case "YellowEmperor":
					yellowPoints += int.Parse (points3Text.text);
					break;
				case "WhiteEmperor":
					whitePoints += int.Parse (points3Text.text);
					break;
				case "RedEmperor":
					redPoints += int.Parse (points3Text.text);
					break;
				default :
					break;
				}
			}
		}


	}
}
