using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomOrangeScript : MonoBehaviour {
	private Vector3 firstPosition;
	private float movingDistance =12f;
	private float movingSpeed = 5f;
	private Rigidbody rb;

	// Use this for initialization
	void Start () {
		firstPosition = transform.position;
	}

	// Update is called once per frame
	void Update () {
		transform.position = new Vector3(transform.position.x, firstPosition.y + Mathf.PingPong(movingSpeed * Time.time, movingDistance), transform.position.z);
	}
}
