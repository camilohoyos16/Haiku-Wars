using UnityEngine;
using System.Collections;
using UnityEngine .SceneManagement ;


public class SoundMenuCredits : MonoBehaviour {

	public static SoundMenuCredits instance;

	void Awake()
	{
		if (!instance)
			instance = this;
		else
			Destroy (gameObject);

		DontDestroyOnLoad (this.gameObject);
	}

	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (SceneManager.GetActiveScene ().name.Equals ("3_Choose Emperador"))
			Destroy (this.gameObject);
	}
}
