using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RoomYellowScript : MonoBehaviour {
    public GameObject ExploadObj;
    public GameObject ExploadPos;
    private Text countText;

    private int maxSize;
    private int minSize;

    private bool isExplosion;

    void Start () {
        maxSize = 200;
        minSize = 120;
        isExplosion = true;
    }


    // Update is called once per frame
    void Update () {
        countText = GameObject.Find("Canvas").transform.Find("CountDown").GetComponent<CountDownScript>().countText;
    }

	void OnCollisionEnter(Collision col){
		if (col.gameObject.tag == "Player" && isExplosion) {
            isExplosion = false;
			StartCoroutine("Explosion");
		}
	}

	private IEnumerator Explosion() {
        countText.color = new Color(186f/255f, 38f/255f, 54f/255f, 1f);
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
        countText.text = "";
		Instantiate (ExploadObj, ExploadPos.transform.position, Quaternion.identity);
		Destroy(gameObject);
        countText.color = new Color(1f, 0.549f, 0f, 1f);
	}
}
