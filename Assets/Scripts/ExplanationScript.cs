using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ExplanationScript : MonoBehaviour {
	private Text explanationText;
	private Color textColor;
	private Color textOriginColor;
	public GameObject Panel;

	private string[] explanationTextList = new string[10];
	private float timer;
	private int interval; //文字の表示間隔(秒)
	private bool isDisplay;

	// Use this for initialization
	void Start () {
		interval = 5;
		isDisplay = true;
		explanationText = GetComponent<Text>();
		textOriginColor = explanationText.color;
		explanationTextList[0] = "赤い部屋を\n目指しましょう";
		explanationTextList[1] = "動かせる部屋と\n動かせない部屋が\nあります";
		explanationTextList[2] = "部屋を移動させるには\nSpace + 方向キー\nで移動させます";
		explanationTextList[3] = "視点変更させるには\nA、Fキーを押します";
		explanationTextList[4] = "1キーを押すと\n俯瞰映像をだせます";
		explanationTextList[5] = "この説明が\n不要であれば\nEキーで消せます";
	}

	// Update is called once per frame
	void Update () {
		textColor = explanationText.color;
		explanationText.color = Color.white;

		if (isDisplay) {
			timer += Time.deltaTime;
			if (timer < interval*1) {
				explanationText.text = explanationTextList[0];
			} else if (timer < interval*2) {
				explanationText.text = explanationTextList[1];
			} else if (timer < interval*3) {
				explanationText.text = explanationTextList[2];
			} else if (timer < interval*4) {
				explanationText.text = explanationTextList[3];
			} else if (timer < interval*5) {
				explanationText.text = explanationTextList[4];
			} else if (timer < interval*6) {
				explanationText.text = explanationTextList[5];
			} else {
				timer = 0;
			}
		} else {
			explanationText.text = "";
			timer = 0;
		}

		if (Input.GetKeyDown(KeyCode.E)) {
			if (isDisplay) {
				isDisplay = false;
				Panel.SetActive(false);
			} else {
				isDisplay = true;
				Panel.SetActive(true);
			}
		}
	}
}
