using UnityEngine;
using System.Collections;
using UnityEngine .SceneManagement ;

public class NewOrderOfTurns : MonoBehaviour {

	public static NewOrderOfTurns instance = null;
	// Use this for initialization
	void Awake()
	{
		if (instance == null)
			instance = this;
		else if (instance != this)
			Destroy(gameObject); 
	}

	void Start () {
		NewTurns ();
		StartCoroutine (NextScene ());
	}
	
	// Update is called once per frame
	void Update () {
	
	}
		
	void NewTurns()
	{
		GameObject firstEmperor = OrganizeTurns.emperorsOrderTurn [0]; 
		for (int i=0; i<4;i++)
		{
			int next=(i + 1) % 4;	
			OrganizeTurns.emperorsOrderTurn [i] = OrganizeTurns.emperorsOrderTurn [next];
		}
		OrganizeTurns.emperorsOrderTurn [3] = firstEmperor;
	}

	IEnumerator NextScene()
	{
		yield return new WaitForSeconds (5f);
		ManageTokens.Instance.endScene ();
		SceneManager.LoadScene ("9_TurnOf");
	}
}
