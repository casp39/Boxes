
﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(BoxCollider))]
public class RoomBlueScript : MonoBehaviour {
	private bool room_active;
	private float room_speed = 10f;
	float cameraRotY;
	private GameObject player;
	private Rigidbody rigidbody;

	// Use this for initialization
	void Start () {
		rigidbody = GetComponent<Rigidbody>();
		player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(this.transform.position, player.transform.position) < 3) {
			room_active = true;
		} else {
			room_active = false;
		}

		//カメラのRotationの取得
		cameraRotY = GameObject.Find("PlayerCamera").transform.eulerAngles.y;

		//キー入力の動作
		if ((315 < cameraRotY  && cameraRotY < 360) || (cameraRotY <= 45)) {
			if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.forward * room_speed;
			} else if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.DownArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.back * room_speed;
			}
		} else if (45 < cameraRotY && cameraRotY <= 135) {
			if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.back * room_speed;
			} else if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.forward * room_speed;
			}
		} else if (135 < cameraRotY && cameraRotY <= 225) {
			if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.UpArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.back * room_speed;
			} else if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.DownArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.forward * room_speed;
			}
		} else {
			if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.RightArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.forward * room_speed;
			} else if ((Input.GetKey(KeyCode.Space) && Input.GetKey(KeyCode.LeftArrow)) && room_active == true) {
				rigidbody.velocity = Vector3.back * room_speed;
			}
		}
	}

	private void OnCollisionEnter (Collision col) {
		if (col.gameObject.tag == "Room") {
			rigidbody.velocity = new Vector3(0,0,0);
			col.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0,0,0);
		}
	}
}
