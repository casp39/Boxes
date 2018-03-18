using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallGenerateScript : MonoBehaviour {
	public GameObject room;
	public GameObject ball;
	GameObject[] obj = new GameObject[100];
	Vector3 ballPosition;
	float timer;
	int interval;
	int count;


	// Use this for initialization
	void Start () {
		timer = 0f;
		interval = 3;
		ballPosition = new Vector3(transform.position.x + Random.Range(-2.5f,2.5f), 12f, transform.position.z + Random.Range(-2.5f,2.5f));
		Instantiate(ball, ballPosition, transform.rotation);
	}

	// Update is called once per frame
	void Update () {
		timer += Time.deltaTime;
		if (timer >= interval) {
			timer = 0f;
			obj[count] = Instantiate(ball, ballPosition, transform.rotation);
			ballPosition = new Vector3(transform.position.x + Random.Range(-2.5f,2.5f), 12f, transform.position.z + Random.Range(-2.5f,2.5f));
			interval = Random.Range(6,12);
			if (count > 1) {
				Destroy(obj[count-2]);
			}
			count++;
		}
	}

}
