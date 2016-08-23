using UnityEngine;
using System.Collections;
using UnityEngine.UI ;

public class RateEachPoem : MonoBehaviour {

	public Dropdown lista;
	public Text rate;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		rate.text = lista.value.ToString ();
	}
}
