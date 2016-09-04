using UnityEngine;
using System.Collections;
using UnityEngine .SceneManagement;

public class SounsChooseHaiku : MonoBehaviour {

	void Awake()
	{
		DontDestroyOnLoad (this.gameObject);
	}

	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name.Equals ("6_ReadThePoem"))
			Destroy (this.gameObject);
	}
}
