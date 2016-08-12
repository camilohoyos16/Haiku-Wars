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
		switch (lista.value) 
		{
		case 0:
			rate.text = lista.value.ToString ();
			break;
		case 1:
			rate.text = lista.value.ToString ();
			break;
		case 2:
			rate.text = lista.value.ToString ();
			break;
		case 3:
			rate.text = lista.value.ToString ();
			break;
		case 4:
			rate.text = lista.value.ToString ();
			break;
		case 5:
			rate.text = lista.value.ToString ();
			break;
		default :
			break;
		}
	}
}
