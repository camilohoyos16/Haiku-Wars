using UnityEngine;
using System.Collections;
using UnityEngine .UI ;
using System .Collections.Generic;

public class ControlPlayerRate : MonoBehaviour {

//	public Dropdown copyDropdown;
	public Dropdown[] placeOfRate= new Dropdown[3];
	public string [] namePositions = new string[3] ;
	public List<Text > positions = new List<Text>();

	public bool primero;
	public bool segundo;
	public bool tercero;

	public string  lastValue="";
	public int newValue=0;

	public string  firstLastValue="";
	public string SecondLastValue="";
	public string thirdLastValue="";



	public static ControlPlayerRate instance;
	public static ControlPlayerRate Instance
	{
		get {
			return instance;
		}
	}

	private void Awake ()
	{			
		primero = false;
		segundo = false;
		tercero = false;
	}

	// Use this for initialization
	void Start () {
		EventButtonSelection.positionCount += CheckPostionPlayer;
		FullListOfDropdown();
		//MakeACopy ();
	}

	public void UpdateForNewTurn ()
	{		
	
	}


	/*void MakeACopy()
	{	
		copyDropdown = GameObject.Find ("Dropdown").GetComponent < Dropdown > ();	
		copyDropdown.ClearOptions();
		copyDropdown.AddOptions (placeOfRate[0].options);		
	}*/

	void FullListOfDropdown()
	{
		for (int i = 0; i < 3; i++) 
		{
			switch (i) {
			case 0:
				placeOfRate [0] = GameObject.Find ("FirstRate").GetComponent <Dropdown> ();
				break;
			case 1:
				placeOfRate [1]= GameObject.Find ("SecondRate").GetComponent <Dropdown> ();
				break;
			case 2:
				placeOfRate [2]= GameObject.Find ("ThirdRate").GetComponent <Dropdown> ();
				break;
			default :
				break;
			}	
		}
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void AddingOthersOptions(string optionName) //AGREGA LAS OPCIONES LUEGO DE CAMBIAR DE OPCION DIFERNETE DE 0. POR SI CAMBIA DE OPCION DIRECTAMENTE
	{
		if (optionName .Equals ("1st Place") && primero ) {	
			for (int i = 0; i < 3; i++) {
				Dropdown dropdown = placeOfRate [i];
				dropdown.options.Insert(1, new Dropdown.OptionData("1st Place"));
			}
			primero = false;
		}				
		if (optionName .Equals ("2nd Place") && segundo ){
			for (int i = 0; i < 3; i++) {
				Dropdown dropdown = placeOfRate [i];
				if (primero) {
					dropdown.options.Insert (1, new Dropdown.OptionData ("2nd Place"));
				} else {
					dropdown.options.Insert (2, new Dropdown.OptionData ("2nd Place"));
				}
			}
			segundo = false;
		}
		if (optionName .Equals ("3rd Place") && tercero){
			for (int i = 0; i < 3; i++) {
				
				Dropdown dropdown = placeOfRate [i];

				if (primero && segundo) {
					dropdown.options.Insert (1, new Dropdown.OptionData ("3rd Place"));
				}
				if (!primero && !segundo) {
					dropdown.options.Insert(3, new Dropdown.OptionData("3rd Place"));
				}else {
					dropdown.options.Insert (2, new Dropdown.OptionData ("3rd Place"));
				}

			
			}
			tercero = false;
		}
	}

	void CheckPostionPlayer (Dropdown dropdownReceived) //RECIBE EL INDEX QUE FUE PRESIONADO. PUEDE SER CUALQUIERA DE LOS 3 DROPSDOWNS
	{			
		
		newValue = dropdownReceived.value;  //GUARDA EL NUMERO DE POSICIÓN DEL INDEX SELECCIONADO
		Debug .Log (newValue );

		Dropdown .OptionData elimina1;
		Dropdown .OptionData elimina2;
		Dropdown .OptionData elimina3;

		if (newValue != 0) {    //SI ES SELESCCIONADO UN INDEX DIFERENTE DE 0 (OPCION NEUTRA), ELIMINA EL INDEX SELECCIONADO DE TODOS LOS DROPDOWNS
			//for (int i = 0; i < 3; i++) {
			//	placeOfRate [i].options.RemoveAt (newValue);
			placeOfRate [0].options.RemoveAt (newValue );
			placeOfRate [1].options.RemoveAt (newValue );			 
			placeOfRate [2].options.RemoveAt (newValue );		
		}

		if (dropdownReceived.name.Equals ("FirstRate")) 
		{			
			int value = dropdownReceived.value;

			switch (value) {
			case 1:
				primero = true;
				break;
			case 2:
				segundo = true;
				break;
			case 3:
				tercero = true;
				break;
			default :
				break;
			}


			if (firstLastValue != "Ranked ...") 
			{
				AddingOthersOptions (firstLastValue);
			}

			switch (firstLastValue) 
			{
			case "Ranked ...":
				AddingOthersOptions (firstLastValue);
				break ;
			case "1st Place":
				primero = false;
				break;
			case "2nd Place":
				segundo = false;
				break;
			case "3rd Place":
				tercero = false;
				break;
			default :
				break;
			}

			firstLastValue = dropdownReceived.captionText.text;
		}

		if (dropdownReceived.name.Equals ("SecondRate")) 
		{
			int value = dropdownReceived.value;

			switch (value) {
			case 1:
				primero = true;
				break;
			case 2:
				segundo = true;
				break;
			case 3:
				tercero = true;
				break;
			default :
				break;
			}


			if (SecondLastValue  != "Ranked ...") 
			{
				AddingOthersOptions (SecondLastValue);
			}

			switch (SecondLastValue ) 
			{
			case "Ranked ...":
				AddingOthersOptions (SecondLastValue);
				break ;
			case "1st Place":
				primero = false;
				break;
			case "2nd Place":
				segundo = false;
				break;
			case "3rd Place":
				tercero = false;
				break;
			default :
				break;
			}

			SecondLastValue = dropdownReceived.captionText.text;
		}

		if (dropdownReceived.name.Equals ("ThirdRate")) 
		{
			int value = dropdownReceived.value;

			switch (value) {
			case 1:
				primero = true;
				break;
			case 2:
				segundo = true;
				break;
			case 3:
				tercero = true;
				break;
			default :
				break;
			}

			if (thirdLastValue  != "Ranked ...") 
			{
				AddingOthersOptions (thirdLastValue);
			}

			switch (thirdLastValue) 
			{
			case "Ranked ...":
				AddingOthersOptions (thirdLastValue );
				break ;
			case "1st Place":
				primero = false;
				break;
			case "2nd Place":
				segundo = false;
				break;
			case "3rd Place":
				tercero = false;
				break;
			default :
				break;
			}

			thirdLastValue = dropdownReceived.captionText.text;
		}

		lastValue= dropdownReceived.captionText.text;
	}

}
