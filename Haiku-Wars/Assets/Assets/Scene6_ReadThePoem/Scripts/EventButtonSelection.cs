using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public delegate void PositionCount(Dropdown target);

public class EventButtonSelection : MonoBehaviour {

	public Dropdown dropdown;
	//public Dropdown lista;
//	public Text rate;


	public static event PositionCount positionCount;

	void Awake()
	{
		
	}

	// Use this for initialization
	void Start () 
	{		
		dropdown = GetComponent <Dropdown > ();
		//dropdown.onValueChanged.AddListener(delegate {
	//		CallEvent(dropdown);
	//	});
	}	

	void Update () {		
	}

	public void CallEvent(Dropdown target)
	{			

		target = dropdown;
		if (positionCount != null)
			positionCount (dropdown );
	}
}
