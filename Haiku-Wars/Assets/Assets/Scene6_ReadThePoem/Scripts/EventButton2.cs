using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public delegate void Event2(Dropdown target);

public class EventButton2 : MonoBehaviour {

	public Dropdown dropdown;
	//public Dropdown lista;
	//	public Text rate;


	public static event Event2 positionCount;

	void Awake()
	{

	}

	// Use this for initialization
	void Start () 
	{		
		dropdown = GameObject.Find ("SecondRate").GetComponent <Dropdown > ();
		//dropdown.onValueChanged.AddListener(delegate {
		//		CallEvent(dropdown);
		//	});
	}	

	void Update () {		
	}

	public void CallEvent(Dropdown target)
	{	
		if (positionCount != null)
			positionCount (dropdown );
	}
}
