using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinsScript : MonoBehaviour {
	public GameObject GameController;

	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

	}

	private void OnTriggerEnter (Collider col) {
		if (col.gameObject.name == "Player") {
			GameController.GetComponent<GameControllerScript>().AdditionalCoinPoints();
			Destroy(gameObject);
		}
	}
}
