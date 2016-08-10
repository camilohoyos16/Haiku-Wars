using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement ;

public class GoScene : MonoBehaviour {

	public float timeForChange;
	public string nameOfScene;

	void Start () {
		if (SceneManager.GetActiveScene().name .Equals("1_Splash Screen"))
		StartCoroutine (MainMenu ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	public IEnumerator MainMenu()
	{
		yield return new WaitForSeconds (timeForChange);
		SceneManager.LoadScene (nameOfScene);
	}

	public void ChangeScene()
	{
		StartCoroutine (MainMenu ());
	}
}
