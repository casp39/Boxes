using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ConveyorDuplicationScript : MonoBehaviour {
	public GameObject ConveyorZ;
	public GameObject ConveyorX;
	public Vector3 conveyorZPosition;
	public Quaternion conveyorZRotation;
	public Vector3 conveyorXPosition;
	public Quaternion conveyorXRotation;
	int i = 0;
	public int conveyorNumber = 15;


	// Use this for initialization
	void Start () {
		ConveyorZ = GameObject.Find("ConveyorZ");
		ConveyorX = GameObject.Find("ConveyorX");
		conveyorZPosition = new Vector3(0f, 14f, 50f);
		conveyorXPosition = new Vector3(50f, 14f, 0f);
		conveyorZRotation = ConveyorZ.transform.rotation;
		conveyorXRotation = ConveyorX.transform.rotation;
		for (i=0; i<conveyorNumber; i++) {
			Instantiate(ConveyorZ, new Vector3(conveyorZPosition.x + 6.0f*(i+1), conveyorZPosition.y, conveyorZPosition.z ), conveyorZRotation);
			Instantiate(ConveyorX, new Vector3(conveyorXPosition.x, conveyorXPosition.y, conveyorXPosition.z + 6.0f*(i+1) ), conveyorXRotation);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
