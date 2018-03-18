using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlinkerBlue : MonoBehaviour {

	public float timeOut = 2;
    private float timeElapsed;
	private bool trigger = true;
	public GameObject arrowForrow;
	public GameObject arrowBack;


    void Start() {

	}


    void Update () {
		timeElapsed += Time.deltaTime;

		if (timeElapsed >= timeOut) {
			if (trigger) {
				arrowForrow.SetActive(false);
				arrowBack.SetActive(false);
				trigger = false;
			} else {
				arrowForrow.SetActive(true);
				arrowBack.SetActive(true);
				trigger = true;
			}
			timeElapsed = 0.0f;
		}
	}
}
