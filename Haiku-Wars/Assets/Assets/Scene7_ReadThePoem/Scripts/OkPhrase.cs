using UnityEngine;
using System.Collections;
using UnityEngine .UI ;
using UnityEngine.SceneManagement;

public class OkPhrase : MonoBehaviour {
	public Text text1;
	public Text text2;
	public Button buton;

	void Awake()
	{
		buton.gameObject.SetActive (false);
	}

	void Start () {
		
	}

	void Update () {
		if (text1.text.Length >0 && text2.text.Length >0)
			buton.gameObject.SetActive (true);
	}

	public void ChanceScene()
	{
		SceneManager.LoadScene ("7_ReadThePoem");
	}
}
