using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallVarticalScript : MonoBehaviour {
	bool direction;

	// Use this for initialization
	void Start () {
		direction = RandomBool();
	}

	// Update is called once per frame
	void Update () {
		if (this.transform.position.z >= 100f) {
			direction = true;
		} else if (this.transform.position.z <= 0f) {
			direction = false;
		}

		if (direction) {
			this.transform.position += new Vector3(0f, 0f, -0.25f);
		} else {
			this.transform.position += new Vector3(0f, 0f, 0.25f);
		}
	}


	public static bool RandomBool() {
		return Random.Range(0, 2) == 0;
	}
	
}
