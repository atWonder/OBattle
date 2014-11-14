using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float countDownTimer = 3;
	public UILabel timerLb;
	bool COUNTDOWNING = false;

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		if (COUNTDOWNING) {
			countDownTimer -= Time.deltaTime;
			int timerInt = (int)Mathf.Round (countDownTimer);
			timerLb.text = timerInt.ToString ();
		}
	}
}
