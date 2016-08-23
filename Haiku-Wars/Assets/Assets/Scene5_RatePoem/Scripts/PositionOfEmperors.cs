using UnityEngine;
using System.Collections;

public class PositionOfEmperors : MonoBehaviour {

	[SerializeField]
	private Vector3 topRightPosition;
	[SerializeField]
	private Quaternion topRightRotation;
	[SerializeField]
	private Vector3 belowRightPosition;
	[SerializeField]
	private Quaternion belowRightRotation;
	[SerializeField]
	private Vector3 belowLeftPosition;
	[SerializeField]
	private Quaternion belowLeftRotation;

	private Vector3[] positions= new Vector3[3] ;
	private Quaternion[] rotations=new Quaternion[3] ;

	public GameObject em1;
	public GameObject em2;
	public GameObject em3;

	void Awake()
	{
		positions [0] = topRightPosition;
		positions [1] = belowRightPosition;
		positions [2] = belowLeftPosition;

		rotations [0] = topRightRotation;
		rotations [1] = belowRightRotation;
		rotations [2] = belowLeftRotation ;
	}

	// Use this for initialization
	void Start () {
		Emperors ();
	}
	
	// Update is called once per frame
	void Update () {
		em1.transform .rotation =  topRightRotation;
		em2 .transform .rotation = belowRightRotation;
		em3.transform .rotation= belowLeftRotation ;
		em1.transform .position  =  topRightPosition;
		em2 .transform .position = belowRightPosition;
		em3.transform .position = belowLeftPosition;
	}

	void Emperors()
	{
		switch (OrganizeTurns.numberTurn) 
		{
		case 1:
			em1=Instantiate (OrganizeTurns.emperorsOrderTurn[1], positions [0], rotations [0]) as GameObject ;
			em2=Instantiate (OrganizeTurns.emperorsOrderTurn[2], positions [1], rotations [1])as GameObject ;		
			em3=Instantiate (OrganizeTurns.emperorsOrderTurn[3], positions [2], rotations [2]) as GameObject ;		
		break;

		case 2:
			Instantiate (OrganizeTurns.emperorsOrderTurn[2], positions [0], rotations [0]);
			Instantiate (OrganizeTurns.emperorsOrderTurn[3], positions [1], rotations [1]);		
			Instantiate (OrganizeTurns.emperorsOrderTurn[0], positions [2], rotations [2]);	
		break;

		case 3:
			Instantiate (OrganizeTurns.emperorsOrderTurn[3], positions [0], rotations [0]);
			Instantiate (OrganizeTurns.emperorsOrderTurn[0], positions [1], rotations [1]);		
			Instantiate (OrganizeTurns.emperorsOrderTurn[1], positions [2], rotations [2]);	
		break;

		case 4:
			Instantiate (OrganizeTurns.emperorsOrderTurn[0], positions [0], rotations [0]);
			Instantiate (OrganizeTurns.emperorsOrderTurn[1], positions [1], rotations [1]);		
			Instantiate (OrganizeTurns.emperorsOrderTurn[2], positions [2], rotations [2]);	
		break;
		}
	}
}
