using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine .SceneManagement;

public class TimeForRead : MonoBehaviour {
	public float segundos;
	private float time;
	private float timeUpdate;
	private float showTime;

	private float reverseTime = 15;

	private Animator fondo;
	private Animator sol;
	private Button startAnimations; 
	private Text timeOut;

	public  Text  text;

	private int turns=0;

	void Awake ()
	{
		text = GameObject.Find ("ClockText").GetComponent <Text >();
		timeOut = GameObject.Find ("TimeOut").GetComponent <Text > ();

		fondo = GameObject.Find ("Background").GetComponent <Animator > ();
		sol = GameObject.Find ("Sun").GetComponent <Animator > ();
		startAnimations = GameObject.Find ("StartAnimations").GetComponent <Button > ();
		timeOut.gameObject.SetActive (false);
	}

	// Use this for initialization
	void Start () {

	}

	void Update ()
	{
		if (startAnimations.gameObject.activeInHierarchy == false) {
			timeUpdate = Time.time - time;
			segundos = (int)(timeUpdate % 60); 
			showTime = reverseTime - segundos;
			text.text = "" + (showTime);
		}

		if (showTime <= 0) 
		{
			fondo.SetBool ("Anochece", false);
			sol.SetBool ("SunDown", false);
			text.text = "15";
			timeOut.gameObject.SetActive (true);
			if (startAnimations.gameObject.activeInHierarchy == false)
				timeOut.GetComponent <Animator>().SetBool ("ShowTimeOut", true);
			startAnimations.gameObject.SetActive (true);
			StartCoroutine (StopTimeOut());
		}
	}

	IEnumerator StopTimeOut()
	{
		yield return new WaitForSeconds (3f);
		timeOut.GetComponent <Animator>().SetBool ("ShowTimeOut", false);

	}

	public void StartTime()
	{
		if (turns <= 2) {
			time = Time.time;
			fondo.SetBool ("Anochece", true);
			sol.SetBool ("SunDown", true);
			timeOut.gameObject.SetActive (false);
		}
		turns++;
		startAnimations.gameObject.SetActive (false);
	}
}
