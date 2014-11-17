using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float countDownTimer = 3;
	float barTimer = 20.0f;
	public UILabel timerLb;
	public UILabel barTimerLb;
	public GameObject subjectobj;
	bool COUNTDOWNING = false;
	bool BarTimerBoo = false;
	private SpriteRenderer spRenderer;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (COUNTDOWNING) {
			countDownTimer -= Time.deltaTime;
			int timerInt = (int)Mathf.Round (countDownTimer);
			timerLb.text = timerInt.ToString ();
			if(timerInt <= 0){
				COUNTDOWNING = false;
				timerLb.text = "START";
				subjectobj.transform.Translate (5.0f, 5, 0);
				BarTimerBoo = true;
			}
		}
		if(BarTimerBoo){
			barTimer -= Time.deltaTime;
			barTimerLb.text = barTimer.ToString();
			if(barTimer <= 0){
				BarTimerBoo = false;
				Debug.Log("next");
			}
		}
	}

	void CountDownStart(){
		COUNTDOWNING = true;
	}
}
