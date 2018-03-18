using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StringScript : MonoBehaviour {
	Vector3 playerPosition;
	Vector3 playerFirstPosition;
	float speed = 5f;

	// Use this for initialization
	void Start () {
		playerPosition = GameObject.Find ("Player").transform.position;
		playerFirstPosition = GameObject.Find ("Player").transform.position;
		this.transform.position = new Vector3(playerPosition.x, playerPosition.y + 0.9f, playerPosition.z);
	}

	// Update is called once per frame
	void Update () {
		playerPosition = GameObject.Find ("Player").transform.position;
		if (this.transform.position.z > 12) {
			this.transform.position = new Vector3(playerPosition.x, playerFirstPosition.y + 0.9f, playerPosition.z);
		} else if (this.transform.position.x < 100) {
			this.transform.position += Vector3.right * speed * Time.deltaTime;
		}
	}
}
