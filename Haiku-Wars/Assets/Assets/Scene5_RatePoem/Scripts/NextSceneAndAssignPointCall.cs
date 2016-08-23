using UnityEngine;
using System.Collections;
using UnityEngine .SceneManagement ;

public class NextSceneAndAssignPointCall : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void NextScene()
	{
		PointsPerEmperor .instance . AssignPoints ();
		SceneManager.LoadScene ("6_TableOfPositions");	
	}
}
