using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CountDownScript : MonoBehaviour {
	public Text countText;
	private int maxSize;
	private int minSize;
	private float textSize;
	private float textAlpha;


	// Use this for initialization
	void Start () {
		countText = GetComponent<Text>();
		maxSize = 200;
		minSize = 120;
		countText.fontSize = 120;
		textSize = maxSize;
		countText.color = new Color(230f/255f, 180f/255f, 34f/255f, 1f);
		StartCoroutine("CountDown");
	}

	// Update is called once per frame
	void Update () {

	}

	IEnumerator CountDown() {
		yield return new WaitForSeconds(1);
		countText.text = "3";
		countText.fontSize += 40;
		countText.fontSize += 40;
		while (countText.fontSize > minSize) {
			yield return null;
			countText.fontSize -= 40;
		}
		yield return new WaitForSeconds(1);


		countText.text = "2";
		countText.fontSize = maxSize;
		while (countText.fontSize > minSize) {
			yield return null;
			countText.fontSize -= 40;
		}
		yield return new WaitForSeconds(1);

		countText.text = "1";
		countText.fontSize = maxSize;
		while (countText.fontSize > minSize) {
			yield return null;
			countText.fontSize -= 40;
		}
		yield return new WaitForSeconds(1);


		countText.text = "GO";
		countText.fontSize = maxSize;
		while (countText.fontSize > minSize) {
			yield return null;
			countText.fontSize -= 40;
		}

		yield return new WaitForSeconds(0.5f);
		countText.text = "";
	}

}
