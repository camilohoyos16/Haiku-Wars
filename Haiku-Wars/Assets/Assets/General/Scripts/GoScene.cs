using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ;

public class GoScene : MonoBehaviour {

	public float timeForChange;
	public string nameOfScene;
	private AudioSource audio;
	void Start () {
		audio = GetComponent<AudioSource > ();
		if (SceneManager.GetActiveScene().name .Equals("1_Splash Screen"))
		StartCoroutine (MainMenu ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public void ButtonClick()
	{
		SceneManager.LoadScene (nameOfScene);
	}


	public IEnumerator MainMenu()
	{
		yield return new WaitForSeconds (timeForChange);
		SceneManager.LoadScene (nameOfScene);
	}

	public void ChangeScene()
	{if (SceneManager.GetActiveScene().name .Equals("3_Choose Emperador"))
		audio.Play ();
		StartCoroutine (MainMenu ());
	}
}
