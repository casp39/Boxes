using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SubBallGenerateScript : MonoBehaviour {
	public GameObject subBall1;
	public GameObject subBall2;
	public GameObject subBall3;
	public GameObject subBall4;
	public GameObject subBall5;
	public GameObject subBall6;
	private Vector3 subBallPosition;

	// Use this for initialization
	void Start () {
		int i;
		for (i=0; i<6; i++) {
			subBallPosition = new Vector3(this.transform.position.x + 6f * Random.Range(0,15), this.transform.position.y + 12.5f, this.transform.position.z + 6f * Random.Range(0,15));
			Instantiate(subBall1, subBallPosition, transform.rotation);
		}
		for (i=0; i<6; i++) {
			subBallPosition = new Vector3(this.transform.position.x + 6f * Random.Range(0,15), this.transform.position.y + 12.5f, this.transform.position.z + 6f * Random.Range(0,15));
			Instantiate(subBall2, subBallPosition, transform.rotation);
		}
		for (i=0; i<6; i++) {
			subBallPosition = new Vector3(this.transform.position.x + 6f * Random.Range(0,15), this.transform.position.y + 12.5f, this.transform.position.z + 6f * Random.Range(0,15));
			Instantiate(subBall3, subBallPosition, transform.rotation);
		}
		for (i=0; i<6; i++) {
			subBallPosition = new Vector3(this.transform.position.x + 6f * Random.Range(0,15), this.transform.position.y + 12.5f, this.transform.position.z + 6f * Random.Range(0,15));
			Instantiate(subBall4, subBallPosition, transform.rotation);
		}
		for (i=0; i<5; i++) {
			subBallPosition = new Vector3(this.transform.position.x + 6f * Random.Range(0,15), this.transform.position.y + 12.5f, this.transform.position.z + 6f * Random.Range(0,15));
			Instantiate(subBall5, subBallPosition, transform.rotation);
		}
		for (i=0; i<5; i++) {
			subBallPosition = new Vector3(this.transform.position.x + 6f * Random.Range(0,15), this.transform.position.y + 12.5f, this.transform.position.z + 6f * Random.Range(0,15));
			Instantiate(subBall6, subBallPosition, transform.rotation);
		}
	}

	// Update is called once per frame
	void Update () {

	}
}
