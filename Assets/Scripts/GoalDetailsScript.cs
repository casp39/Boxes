using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GoalDetailsScript : MonoBehaviour {
	public Text goalText;
	private int totalScore;
	private int coinScore;
	private int collisionScore;
	private int number1;
	private int number2;
	private int number3;
	private int number4;
	private int number5;

	public int remainingMinute;
	public float remainingSeconds;

	// Use this for initialization
	void Start () {
		goalText = GetComponentInChildren<Text>();
		totalScore = 23400;
		coinScore = 3;
		collisionScore = 4;
		number1 = 0;
		number2 = 0;
		number3 = 0;
		number4 = 0;
		number5 = 0;

		remainingMinute  = GameControllerScript.getRemainingMinute();
		remainingSeconds  = GameControllerScript.getRemainingSeconds();
	}

	// Update is called once per frame
	void Update () {
		if (number1 < remainingMinute) {
			number1 += 1;
			goalText.text = "_Details_______________\n\n■Time " + number1 + ":" + number2 + "\n\n■Coin" + number3 + "\n\n■Collision" + number4 + "\n\nTotal Score " + number5;
		}
		if (number2 < (int)remainingSeconds) {
			number2 += 1;
			goalText.text = "_Details_______________\n\n■Time " + number1 + ":" + number2 + "\n\n■Coin" + number3 + "\n\n■Collision" + number4 + "\n\nTotal Score " + number5;
		}
		if (number3 < coinScore) {
			number3 += 1;
			goalText.text = "_Details_______________\n\n■Time " + number1 + ":" + number2 + "\n\n■Coin" + number3 + "\n\n■Collision" + number4 + "\n\nTotal Score " + number5;
		}
		if (number4 < collisionScore) {
			number4 += 1;
			goalText.text = "_Details_______________\n\n■Time " + number1 + ":" + number2 + "\n\n■Coin" + number3 + "\n\n■Collision" + number4 + "\n\nTotal Score " + number5;
		}
		if (number5 < totalScore-200) {
			number5 += 197;
			goalText.text = "_Details_______________\n\n■Time " + number1 + ":" + number2 + "\n\n■Coin " + number3 + "\n\n■Collision " + number4 + "\n\nTotal Score " + number5;
		} else {
			goalText.text = "_Details_______________\n\n■Time " + remainingMinute + ":" + (int)remainingSeconds + "\n\n■Coin " + coinScore + "\n\n■Collision " + collisionScore + "\n\nTotal Score " + totalScore;
		}
	}
}
