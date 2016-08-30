using UnityEngine;
using System.Collections;

public class ManageTokens : MonoBehaviour {

	public static ManageTokens instance = null;
	public static ManageTokens Instance
	{
		get
		{
			return instance;
		}
	}


	public GameObject [] blueTokens = new GameObject[6];
	public GameObject [] whiteTokens = new GameObject[6];
	public GameObject [] redTokens = new GameObject[6];
	public GameObject [] yellowTokens = new GameObject[6];

	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject);  

		DontDestroyOnLoad (this.gameObject);

		for (int i = 0; i < 6; i++) 
		{
			blueTokens [i].SetActive (false);
			whiteTokens [i].SetActive (false);
			redTokens [i].SetActive (false);
			yellowTokens [i].SetActive (false);
		}
	}

	public void startScene()
	{
		for (int i = 0; i < PointsPerEmperor.Instance.bluePoints; i++) 
		{
			blueTokens [i].SetActive (true);
		}
		for (int i = 0; i < PointsPerEmperor.Instance.whitePoints ; i++) 
		{
			whiteTokens [i].SetActive (true);
		}
		for (int i = 0; i < PointsPerEmperor.Instance.redPoints ; i++) 
		{
			redTokens[i].SetActive (true);
		}
		for (int i = 0; i < PointsPerEmperor.Instance.yellowPoints; i++) 
		{
			yellowTokens [i].SetActive (true);
		}
	}

	public void endScene()
	{
		for (int i = 0; i < 6; i++) 
		{
			blueTokens [i].SetActive (false);
			whiteTokens [i].SetActive (false);
			redTokens [i].SetActive (false);
			yellowTokens [i].SetActive (false);
		}
	}
	// Use this for initialization
	void Start () {


	}

	void showTokens()
	{
		

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
