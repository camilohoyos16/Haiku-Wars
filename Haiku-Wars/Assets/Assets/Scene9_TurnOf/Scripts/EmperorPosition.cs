using UnityEngine;
using System.Collections;
using UnityEngine .SceneManagement ;

public class EmperorPosition : MonoBehaviour {

	[SerializeField]
	private Vector3 emperorPosition;
	[SerializeField]
	private Quaternion emperorRotation;
	[SerializeField]
	private Vector3 emperorScale;

	public GameObject red;
	public GameObject yellow;
	public GameObject white;
	public GameObject blue;

	public GameObject em0;

	void Start () {
		if (SceneManager.GetActiveScene ().name.Equals ("11_Winner")) {
			if (PointsPerEmperor.Instance.bluePoints >= 6)
				em0 = Instantiate (blue, emperorPosition, emperorRotation) as GameObject; 
			if(PointsPerEmperor.Instance.whitePoints >= 6)
				em0 = Instantiate (white, emperorPosition, emperorRotation) as GameObject;
			if(PointsPerEmperor.Instance.redPoints >= 6)
				em0 = Instantiate (red, emperorPosition, emperorRotation) as GameObject;
			if(PointsPerEmperor.Instance.yellowPoints >= 6) 
				em0 = Instantiate (yellow , emperorPosition, emperorRotation) as GameObject;
		} else {
			em0 = Instantiate (OrganizeTurns.emperorsOrderTurn [0], emperorPosition, emperorRotation) as GameObject;
		}
	}
	
	// Update is called once per frame
	void Update () {
		em0.transform.position = emperorPosition;
		em0.transform.rotation = emperorRotation;
	}
}
