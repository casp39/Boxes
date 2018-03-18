using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightBlueScript : MonoBehaviour {
	private float light_speed = 0.1f;
	// Use this for initialization
	void Start () {
	}

	// Update is called once per frame
	void Update () {
		GetComponent<Renderer>().material.color = new Color(0f, 0f, 1f, (Mathf.Sin(light_speed * Time.frameCount) + 1)/2);
	}
}
