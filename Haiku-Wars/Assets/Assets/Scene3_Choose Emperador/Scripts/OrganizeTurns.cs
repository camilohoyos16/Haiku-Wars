using UnityEngine;
using System.Collections;
using UnityEngine .UI;
public class OrganizeTurns : MonoBehaviour {

	public GameObject emperorRed;
	public GameObject emperorYellow;
	public GameObject emperorBlue;
	public GameObject emperorWhite;

	public static GameObject[] emperorsOrderTurn= new GameObject[4] ;
	public Image[] cardsEmperors = new Image [4];

	public static int numberTurn = 1;
	public static OrganizeTurns instance = null; 

	void Awake ()
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
	void Update () 
	{
		
	}

	public void AdministerTurns()
	{
		int current = 0;
		for (int i = 0; i < 4; i++) {
			if (cardsEmperors [i].sprite.name.Equals ("red")) {
				current = i;
				Debug.Log (current);
			}
		}
		emperorsOrderTurn [0] = emperorRed;
		int selected=(current + 1) % 4;
		for (int i=1; i< 4; i++) {
			current ++;
			switch (cardsEmperors [selected].sprite.name) {
			case "blue":
				emperorsOrderTurn [i] = emperorBlue;
				break;
			case "White":
				emperorsOrderTurn [i]= emperorWhite;
				break;
			case "Yellow":
				emperorsOrderTurn [i] = emperorYellow;
				break;
			default :
				break;				
			}
			selected = (current + 1) % 4;
		}
	}
}
