using UnityEngine;
using System.Collections;
using UnityEngine .UI;
public class OrganizeTurns : MonoBehaviour {

	public GameObject emperorRed;
	public GameObject emperorYellow;
	public GameObject emperorBlue;
	public GameObject emperorWhite;

	public static GameObject[] turns= new GameObject[4] ;
	public Image[] cardsEmperors = new Image [4];

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
	{
		AdministerTurns();
	}

	public void AdministerTurns()
	{
		int current = 0;
		for (int i = 0; i < 4; i++) 
		{
			if (cardsEmperors [i].name.Equals ("red"))
				current = i;
		}
		turns [0] = emperorRed;
		int selected = (current + 1) % 4;

	}
}
