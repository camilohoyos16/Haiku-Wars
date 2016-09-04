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
	private GameObject RedTimeImage;

	public  Text  text;

	private int turns=0;
	private AudioSource audio;
	private AudioSource timeUpAudio;
	private AudioSource backgroundSound;

	void Awake ()
	{
		text = GameObject.Find ("ClockText").GetComponent <Text >();
		timeOut = GameObject.Find ("TimeOut").GetComponent <Text > ();
		RedTimeImage  = GameObject.Find ("RedTime");

		fondo = GameObject.Find ("Background").GetComponent <Animator > ();
		sol = GameObject.Find ("Sun").GetComponent <Animator > ();
		startAnimations = GameObject.Find ("StartAnimations").GetComponent <Button > ();
		timeOut.gameObject.SetActive (false);
		RedTimeImage.SetActive (false);
		audio = GetComponent<AudioSource > ();
		timeUpAudio = GameObject.Find ("SoundTimeUp").GetComponent<AudioSource > ();
		backgroundSound  = GameObject.Find ("SoundWaitPoem").GetComponent<AudioSource > ();

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
			
			if (startAnimations.gameObject.activeInHierarchy == false) {
				//fondo.SetBool ("Anochece", false);
			//	sol.SetBool ("SunDown", false);
				audio.Stop ();
				backgroundSound.Play ();
				text.text = "15";
				timeOut.gameObject.SetActive (true);
				RedTimeImage.SetActive (true);

				timeOut.GetComponent <Animator> ().SetBool ("ShowTimeOut", true);
				timeUpAudio.Play ();
			
				startAnimations.gameObject.SetActive (true);
				StartCoroutine (StopTimeOut ());
			}
		}
	}

	IEnumerator StopTimeOut()
	{
		yield return new WaitForSeconds (3f);
		timeOut.GetComponent <Animator>().SetBool ("ShowTimeOut", false);
		RedTimeImage.SetActive (false);


	}

	public void StartTime()
	{
		if (turns <= 2) {
			audio.Play ();
			backgroundSound.Stop ();
			time = Time.time;
			fondo.SetBool ("Anochece", false);
			sol.SetBool ("SunDown", false);
			//fondo.SetBool ("Anochece", true);
			//sol.SetBool ("SunDown", true);
			//timeOut.gameObject.SetActive (false);
			StartCoroutine(ActiveAnimations ()); 
		}
		turns++;
		startAnimations.gameObject.SetActive (false);
	}

	IEnumerator ActiveAnimations()
	{
		yield return new WaitForSeconds (0.2f);
		fondo.SetBool ("Anochece", true);
		sol.SetBool ("SunDown", true);
		timeOut.gameObject.SetActive (false);
	}
}
