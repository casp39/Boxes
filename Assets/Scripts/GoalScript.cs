using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GoalScript : MonoBehaviour {
	GameObject player;
	public GameObject gameController;


	// Use this for initialization
	void Start () {
		player = GameObject.Find("Player");
	}

	// Update is called once per frame
	void Update () {
		if (Vector3.Distance(this.transform.position, player.transform.position) < 1) {
			gameController.GetComponent<GameControllerScript>().ChangeIsGoal();
			// SceneManager.LoadScene("Goal");
		}
	}

}
