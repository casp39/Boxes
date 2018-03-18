using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameControllerScript : MonoBehaviour {
	private GameObject player;
	public GameObject SubCam1;
	public GameObject SubCam2;
	public GameObject goalText;
	public GameObject timer;

	public int coinPoints;	   //コインポイント
	public float startTime;	   //ゲーム開始の時間
	public float finishTime;   //ゲーム終了の時間
	public static int remainigMinute;      //残り時間
	public static float remainigSeconds;   //残り時間

	public bool GameOn;          //ゲームスタート判定
	public bool isGoal;          //ゴール判定
	public bool isExplanation;	 //説明板判定

	//getter
	public static int getRemainingMinute() {
		return remainigMinute;
	}
	public static float getRemainingSeconds() {
		return remainigSeconds;
	}



	// Use this for initialization
	void Start () {
		//コインポイント初期設定
		coinPoints = 0;

		//各種トリガー初期設定
		GameOn = false;
		isGoal = false;
		isExplanation = true;

		//各種オブジェクト初期設定
		player = GameObject.Find("Player");

		//サブカメラ初期設定
		SubCam1.SetActive(false);
		SubCam2.SetActive(false);

		//ゲーム開始までの時間
		StartCoroutine ("Wait3");

		//開始時間のセット
		startTime = timer.GetComponent<TimerScript>().totalTime;
	}

	// Update is called once per frame
	void Update () {
		//シーンリセット
		if (player.transform.position.y < -20) {
			SceneManager.LoadScene("Main");
		} else if (Input.GetKeyDown(KeyCode.Z)) {
			SceneManager.LoadScene("Main");
		}

		//サブカメラの処理
		SubCam1.transform.position = new Vector3(player.transform.position.x, player.transform.position.y + 30, player.transform.position.z);

		if (Input.GetKey(KeyCode.Alpha1)) {
			SubCam1.SetActive (true);
			SubCam2.SetActive (false);
		} else if (Input.GetKey(KeyCode.Alpha2)) {
			SubCam1.SetActive (false);
			SubCam2.SetActive (true);
		} else {
			SubCam1.SetActive (false);
			SubCam2.SetActive (false);
		}

		//ゴール後の処理
		if (isGoal) {
			//Canvasに"ゴール"を表示
			goalText.GetComponent<GoalTextScript>().DisplayGoal();
			StartCoroutine("waitSecondsAndGoal",2);

			//終了時刻の設定
			finishTime = timer.GetComponent<TimerScript>().totalTime;
			remainigMinute = (int) finishTime / 60;
			remainigSeconds = finishTime - remainigMinute * 60;
		}

	}

	//ゲームをスタートするまでの余時間
	private IEnumerator Wait3 () {
		yield return new WaitForSeconds (5.0f);
		GameOn = true;
	}

	//i秒間処理を待ってゴールシーンへ
	private IEnumerator waitSecondsAndGoal(int i) {
		yield return new WaitForSeconds(i);
		SceneManager.LoadScene("Goal");
	}

	//ゴール判定
	public void ChangeIsGoal () {
		isGoal = true;
		GameOn = false;
	}

	//コインポイント増加
	public void AdditionalCoinPoints () {
		coinPoints += 1;
	}
}
