using UnityEngine;
using System.Collections;
using UnityEngine .UI ;

public class ReloadDropdowns : MonoBehaviour {

	private Dropdown copyDropdown;
	private bool copiaLista = false;

	private Dropdown [] listOfDropdowns = new Dropdown[3] ;

	public static ReloadDropdowns instance=null;
	public static ReloadDropdowns Instance
	{
		get{
			return instance;
		}
	}

	void Awake()
	{
		if (!instance)
			instance = this;
		else
			Destroy (gameObject);
		
		DontDestroyOnLoad (this.gameObject);

		copyDropdown = GameObject.Find ("Dropdown").GetComponent <Dropdown > ();
	}

	// Use this for initialization
	void Start () {
		
	}

	void MakeACopy()
	{	
		copyDropdown = GameObject.Find ("Dropdown").GetComponent < Dropdown > ();	
		copyDropdown.ClearOptions();
		copyDropdown.AddOptions (listOfDropdowns[0].options);	
	}

	public void FullDropdownsList()
	{
		for (int i = 0; i < 3; i++) 
		{
			switch (i) {
			case 0:
				listOfDropdowns [0] = GameObject.Find ("FirstRate").GetComponent <Dropdown> ();
				break;
			case 1:
				listOfDropdowns [1]= GameObject.Find ("SecondRate").GetComponent <Dropdown> ();
				break;
			case 2:
				listOfDropdowns [2]= GameObject.Find ("ThirdRate").GetComponent <Dropdown> ();
				break;
			default :
				break;
			}	
		}
		if (!copiaLista)
			MakeACopy ();
		UpdateDropdowns ();
	}

	void UpdateDropdowns ()
	{
		for (int i = 0; i < 3; i++) 
		{
			listOfDropdowns [i].ClearOptions ();
		}

		for (int i = 0; i < 3; i++) 
		{
			listOfDropdowns [i].AddOptions (copyDropdown.options);
		}


	}

	
	// Update is called once per frame
	void Update () {
	
	}
}
