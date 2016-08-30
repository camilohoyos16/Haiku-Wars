using UnityEngine;
using System.Collections;
using UnityEngine .UI ;
using UnityEngine .SceneManagement;

public class PointsPerEmperor : MonoBehaviour {
	
	public int bluePoints;
	public int yellowPoints;
	public int redPoints;
	public int whitePoints;

	public Dropdown points1Text;
	public Dropdown points2Text;
	public Dropdown points3Text;

	private Button nextScene;

	public static PointsPerEmperor instance = null;
	public static PointsPerEmperor Instance {
		get{
			return instance;
		}
	}

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
		points1Text = GameObject.Find ("FirstRate").GetComponent <Dropdown > ();
		points2Text = GameObject.Find ("SecondRate").GetComponent <Dropdown > ();
		points3Text = GameObject.Find ("ThirdRate").GetComponent <Dropdown > ();
		nextScene = GameObject.Find ("NextSceneButton").GetComponent <Button > ();
	}

	void Start () {
///		Debug .Log (OrganizeTurns.emperorsOrderTurn [0].name);
	}	

	void Update () 
	{
		if (SceneManager.GetActiveScene().name .Equals("6_ReadThePoem")){
		if (points1Text.captionText.text.Equals ("Ranked ...") || points2Text.captionText.text.Equals ("Ranked ...") || points3Text.captionText.text.Equals ("Ranked ..."))
			nextScene.interactable = false;
		else
			nextScene.interactable = true;
		}
	}

	public void AssignPoints()
	{				
		switch (points1Text.captionText.text) 
		{
		case "1st Place":
			switch (OrganizeTurns.emperorsOrderTurn [1].name) 
			{
			case "BlueEmperor":
				bluePoints += 2;
				break;
			case "YellowEmperor":
				yellowPoints += 2;
				break;
			case "WhiteEmperor":
				whitePoints += 2;
				break;
			case "RedEmperor":
				redPoints += 2;
				break;
			default :
				break;
			}
			break;
		case "2nd Place":
			switch (OrganizeTurns.emperorsOrderTurn [1].name) 
			{
			case "BlueEmperor":
				bluePoints += 1;
				break;
			case "YellowEmperor":
				yellowPoints += 1;
				break;
			case "WhiteEmperor":
				whitePoints += 1;
				break;
			case "RedEmperor":
				redPoints += 1;
				break;
			default :
				break;
			}
			break;
		case "3rd Place":
			switch (OrganizeTurns.emperorsOrderTurn [1].name) 
			{
			case "BlueEmperor":
				bluePoints += 0;
				break;
			case "YellowEmperor":
				yellowPoints += 0;
				break;
			case "WhiteEmperor":
				whitePoints += 0;
				break;
			case "RedEmperor":
				redPoints += 0;
				break;
			default :
				break;
			}
			break;
		default :
			break;
		}
		

		switch (points2Text.captionText.text) 
		{
		case "1st Place":
			switch (OrganizeTurns.emperorsOrderTurn [2].name) 
			{
			case "BlueEmperor":
				bluePoints += 2;
				break;
			case "YellowEmperor":
				yellowPoints += 2;
				break;
			case "WhiteEmperor":
				whitePoints += 2;
				break;
			case "RedEmperor":
				redPoints += 2;
				break;
			default :
				break;
			}
			break;
		case "2nd Place":
			switch (OrganizeTurns.emperorsOrderTurn [2].name) 
			{
			case "BlueEmperor":
				bluePoints += 1;
				break;
			case "YellowEmperor":
				yellowPoints += 1;
				break;
			case "WhiteEmperor":
				whitePoints += 1;
				break;
			case "RedEmperor":
				redPoints += 1;
				break;
			default :
				break;
			}
			break;
		case "3rd Place":
			switch (OrganizeTurns.emperorsOrderTurn [2].name) 
			{
			case "BlueEmperor":
				bluePoints += 0;
				break;
			case "YellowEmperor":
				yellowPoints += 0;
				break;
			case "WhiteEmperor":
				whitePoints += 0;
				break;
			case "RedEmperor":
				redPoints += 0;
				break;
			default :
				break;
			}
			break;
		default :
			break;
		}

		switch (points3Text.captionText.text) 
		{
		case "1st Place":
			switch (OrganizeTurns.emperorsOrderTurn [3].name) 
			{
			case "BlueEmperor":
				bluePoints += 2;
				break;
			case "YellowEmperor":
				yellowPoints += 2;
				break;
			case "WhiteEmperor":
				whitePoints += 2;
				break;
			case "RedEmperor":
				redPoints += 2;
				break;
			default :
				break;
			}
			break;
		case "2nd Place":
			switch (OrganizeTurns.emperorsOrderTurn [3].name) 
			{
			case "BlueEmperor":
				bluePoints += 1;
				break;
			case "YellowEmperor":
				yellowPoints += 1;
				break;
			case "WhiteEmperor":
				whitePoints += 1;
				break;
			case "RedEmperor":
				redPoints += 1;
				break;
			default :
				break;
			}
			break;
		case "3rd Place":
			switch (OrganizeTurns.emperorsOrderTurn [3].name) 
			{
			case "BlueEmperor":
				bluePoints += 0;
				break;
			case "YellowEmperor":
				yellowPoints += 0;
				break;
			case "WhiteEmperor":
				whitePoints += 0;
				break;
			case "RedEmperor":
				redPoints += 0;
				break;
			default :
				break;
			}
			break;
		default :
			break;
		}

	}
}
