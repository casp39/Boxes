using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	float cameraRotY;
	float player_speed = 10f;
	Renderer Renderer;
	private Collider col;
	private float dynFriction;
	private float statFriction;
	private bool GameOn;


	void Awake () {
		Renderer = GetComponent<Renderer>();
	}

	// Use this for initialization
	void Start () {
		col = GetComponent<Collider>();
		dynFriction = 0.2f;
		statFriction = 0.2f;
	}


	// Update is called once per frame
	void Update () {
		cameraRotY = GameObject.Find("PlayerCamera").transform.eulerAngles.y;


		GameOn = GameObject.Find("GameController").GetComponent<GameControllerScript>().GameOn;


		//摩擦力変更
		if (!GameOn) {
			col.material.dynamicFriction = dynFriction;
			col.material.staticFriction = statFriction;
		} else {
			col.material.dynamicFriction = 200f;
			col.material.staticFriction = 300f;
		}



		//プレイヤーキー操作
		if (GameOn) {
			if ((315 < cameraRotY  && cameraRotY < 360) || (cameraRotY <= 45)) {
				if (Input.GetKey(KeyCode.RightArrow)) {
					transform.position += new Vector3 (player_speed * Time.deltaTime, 0, 0);
				} else if (Input.GetKey(KeyCode.LeftArrow)) {
					transform.position += new Vector3 (-player_speed * Time.deltaTime, 0, 0);
				} else if (Input.GetKey(KeyCode.UpArrow)) {
					transform.position += new Vector3 (0, 0, player_speed * Time.deltaTime);
				} else if (Input.GetKey(KeyCode.DownArrow)) {
					transform.position += new Vector3 (0, 0, -player_speed * Time.deltaTime);
				}
			} else if (45 < cameraRotY && cameraRotY <= 135) {
				if (Input.GetKey(KeyCode.RightArrow)) {
					transform.position += new Vector3 (0, 0, -player_speed * Time.deltaTime);
				} else if (Input.GetKey(KeyCode.LeftArrow)) {
					transform.position += new Vector3 (0, 0, +player_speed * Time.deltaTime);
				} else if (Input.GetKey(KeyCode.UpArrow)) {
					transform.position += new Vector3 (player_speed * Time.deltaTime, 0, 0);
				} else if (Input.GetKey(KeyCode.DownArrow)) {
					transform.position += new Vector3 (-player_speed * Time.deltaTime, 0, 0);
				}
			} else if (135 < cameraRotY && cameraRotY <= 225) {
				if (Input.GetKey(KeyCode.RightArrow)) {
					transform.position += new Vector3 (-player_speed * Time.deltaTime, 0, 0);
				} else if (Input.GetKey(KeyCode.LeftArrow)) {
					transform.position += new Vector3 (player_speed * Time.deltaTime, 0, 0);
				} else if (Input.GetKey(KeyCode.UpArrow)) {
					transform.position += new Vector3 (0, 0, -player_speed * Time.deltaTime);
				} else if (Input.GetKey(KeyCode.DownArrow)) {
					transform.position += new Vector3 (0, 0, player_speed * Time.deltaTime);
				}
			} else {
				if (Input.GetKey(KeyCode.RightArrow)) {
					transform.position += new Vector3 (0, 0, player_speed * Time.deltaTime);
				} else if (Input.GetKey(KeyCode.LeftArrow)) {
					transform.position += new Vector3 (0, 0, -player_speed * Time.deltaTime);
				} else if (Input.GetKey(KeyCode.UpArrow)) {
					transform.position += new Vector3 (-player_speed * Time.deltaTime, 0, 0);
				} else if (Input.GetKey(KeyCode.DownArrow)) {
					transform.position += new Vector3 (player_speed * Time.deltaTime, 0, 0);
				}
			}
		}
	}

	private void OnCollisionStay (Collision col) {
		if (Input.GetKey(KeyCode.Space)) {
			this.transform.position = col.gameObject.transform.position + new Vector3(0, 0.8f, 0);
		}
	}

	private void OnCollisionEnter (Collision col) {
		// Color colColor = col.transform.Find("room_floor").GetComponent<Renderer>().material.color;
		// Renderer.material.color = new Color(colColor.r, colColor.g, colColor.b);
	}
}
