using UnityEngine;
using System.Collections;
using UnityEngine.UI ;
public class Animations : MonoBehaviour {

	private Animator fondo;
	private Animator sol;
	private Button startAnimations; 

	void Awake()
	{
		fondo = GameObject.Find ("Background").GetComponent <Animator > ();
		sol = GameObject.Find ("Sun").GetComponent <Animator > ();
		startAnimations = GameObject.Find ("StartAnimations").GetComponent <Button > ();
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
