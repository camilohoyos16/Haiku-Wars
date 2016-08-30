using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ;

public class NextScene : MonoBehaviour {

	public float timeForChange;
	public string nameOfScene;

	void Start () {
		StartCoroutine (MainMenu ());
	}

	public IEnumerator MainMenu()
	{
		yield return new WaitForSeconds (timeForChange);
		SceneManager.LoadScene (nameOfScene);
	}

}
