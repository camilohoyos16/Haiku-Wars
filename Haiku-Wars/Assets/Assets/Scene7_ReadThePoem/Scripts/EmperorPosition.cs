using UnityEngine;
using System.Collections;

public class EmperorPosition : MonoBehaviour {

	[SerializeField]
	private Vector3 emperorPosition;
	[SerializeField]
	private Quaternion emperorRotation;
	[SerializeField]
	private Vector3 emperorScale;

	public GameObject em0;

	void Start () {
		em0 = Instantiate (OrganizeTurns.emperorsOrderTurn [0],emperorPosition , emperorRotation) as GameObject;
	}
	
	// Update is called once per frame
	void Update () {
		em0.transform.position = emperorPosition;
		em0.transform.rotation = emperorRotation;
	}
}
