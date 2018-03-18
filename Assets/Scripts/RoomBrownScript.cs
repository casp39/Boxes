using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoomBrownScript : MonoBehaviour {
	GameObject player;
	Rigidbody playerRb;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		playerRb = GameObject.Find("Player").GetComponent<Rigidbody>();
	}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(player.transform.position, this.transform.position) < 1) {
			playerRb.AddForce(new Vector3(0f, 20f, 100f), ForceMode.Impulse);
		}
	}

}
