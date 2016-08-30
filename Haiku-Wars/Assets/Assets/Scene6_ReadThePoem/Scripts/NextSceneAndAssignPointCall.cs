using UnityEngine;
using System.Collections;
using UnityEngine .SceneManagement ;

public class NextSceneAndAssignPointCall : MonoBehaviour {

	private AudioSource hai;
	// Use this for initialization
	void Start () {
		hai = GetComponent <AudioSource> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	public void ChanceScene()
	{
		hai.Play ();
		StartCoroutine (NextScene ());
	}

	IEnumerator NextScene()
	{
		PointsPerEmperor .instance . AssignPoints ();
		yield return new WaitForSeconds (1);
		SceneManager.LoadScene ("8_TableOfPositions");
	}
}
