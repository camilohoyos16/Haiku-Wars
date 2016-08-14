using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine .SceneManagement;

public class TimeForRead : MonoBehaviour {
	public float segundos;
	private float time;
	private float timeUpdate;

	private float reverseTime = 30;

	public Text  text;

	// Use this for initialization
	void Start () {
		time = Time.time;
	}

	void Update ()
	{
		timeUpdate = Time.time - time;
		segundos = (int)(timeUpdate % 60); 
		text.text = ""+ (reverseTime - segundos);

		if (segundos == 30)
			SceneManager.LoadScene ("5_RatePoem");
	}
}
