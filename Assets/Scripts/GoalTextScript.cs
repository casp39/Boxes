using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalTextScript : MonoBehaviour {
	public Text goalText;
	private int maxSize;
	private int minSize;
	private float textAlpha;


	// Use this for initialization
	void Start () {
		goalText = GetComponent<Text>();
		maxSize = 200;
		minSize = 110;
		goalText.fontSize = maxSize;
		goalText.color = new Color(230f/255f, 180f/255f, 34f/255f, 1f);
		textAlpha = 0f;
	}

	// Update is called once per frame
	void Update () {
	}

	public void DisplayGoal() {
		goalText.text = "GOAL";
		if (goalText.fontSize >= minSize) {
			goalText.fontSize -= (int)(200 * Time.deltaTime);
		}
	}


}
