using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerScript : MonoBehaviour {

	//トータル制限時間
	public float totalTime;
	//制限時間（分）
	public int minute;
	//制限時間（秒）
	public float seconds;
	//前回Update時の秒数
	private float oldSeconds;
	private Text timerText;
	private bool TimerGameOn;

	void Start () {
		seconds = 0f;
		minute = 5;
		totalTime = minute * 60 + seconds;
		oldSeconds = 0f;
		timerText = GetComponentInChildren<Text>();
	}

	void Update () {
		TimerGameOn = GameObject.Find("GameController").GetComponent<GameControllerScript>().GameOn;

		if (TimerGameOn) {
			//制限時間が0秒以下なら何もしない
			if (totalTime <= 0f) {
				return;
			}
			//一旦トータルの制限時間を計測
			totalTime = minute * 60 + seconds;
			totalTime -= Time.deltaTime;

			//再設定
			minute = (int) totalTime / 60;
			seconds = totalTime - minute * 60;

			//タイマー表示用UIテキストに時間を表示する
			if((int)seconds != (int)oldSeconds) {
				timerText.text = "TIME " + minute.ToString("00") + ":" + ((int) seconds).ToString("00");
			}
			oldSeconds = seconds;
			//制限時間以下
			if(totalTime <= 0f) {
				Debug.Log("Finish!");
			}
		}
	}
}
