using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public delegate void Event3(Dropdown target);

public class EventButton3 : MonoBehaviour {

	public Dropdown dropdown;
	//public Dropdown lista;
	//	public Text rate;


	public static event Event3 positionCount;

	void Awake()
	{

	}

	// Use this for initialization
	void Start () 
	{		
		dropdown = GameObject.Find ("ThirdRate").GetComponent <Dropdown > ();
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
