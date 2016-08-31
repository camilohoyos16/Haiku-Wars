using UnityEngine;
using System.Collections;

public class RatePoemLoad : MonoBehaviour {

	void Awake()
	{
	}

	void Start () {
		
		PointsPerEmperor .instance.FindThings ();
		ReloadDropdowns.Instance.FullDropdownsList ();
		ControlPlayerRate.Instance.FullListOfDropdown ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
