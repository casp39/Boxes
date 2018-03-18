using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkerGreen : MonoBehaviour {

	public float timeOut = 2;
    private float timeElapsed;
	private bool trigger = true;
	public GameObject arrowRight;
	public GameObject arrowLeft;


    void Start() {

	}


    void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed >= timeOut) {
			if (trigger) {
				arrowRight.SetActive(false);
				arrowLeft.SetActive(false);
				trigger = false;
			} else {
				arrowRight.SetActive(true);
				arrowLeft.SetActive(true);
				trigger = true;
			}
			timeElapsed = 0.0f;
		}
	}
}
