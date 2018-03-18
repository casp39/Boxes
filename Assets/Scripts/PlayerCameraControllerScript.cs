using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCameraControllerScript : MonoBehaviour {
	public float angle = -90f;
	public float radius = 12f;
	public float rotationalSpeed = 6f;
	private GameObject player;
	private Vector3 thisPosition;

	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
		thisPosition = this.transform.position;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKey(KeyCode.F)) {
			angle -= rotationalSpeed;
		} else if (Input.GetKey(KeyCode.A)) {
			angle += rotationalSpeed;
		}

		//カメラの位置制御
		this.transform.position = new Vector3(player.transform.position.x + radius * Mathf.Cos(2*Mathf.PI*angle/360), player.transform.position.y + 5 , player.transform.position.z + radius * Mathf.Sin(2*Mathf.PI*angle/360));
		this.transform.rotation = Quaternion.Euler(10, -90-angle, 0);
	}
}
