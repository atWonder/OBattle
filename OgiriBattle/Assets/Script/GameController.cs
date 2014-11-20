using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour {

	float countDownTimer = 4;
	float barTimer = 20.0f;
	public UILabel timerLb;
	public UILabel barTimerLb;
	public GameObject subjectobj;
	bool COUNTDOWNING = false;
	bool BarTimerBoo = false;
	private SpriteRenderer spRenderer;
	public GameObject bar;
	float barScale;
	int playerNum;

	public UIButton Dbt;
	public UIButton Ebt;
	public UIButton Fbt;

	public GameObject answerSelect;
	public GameObject answerController;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (COUNTDOWNING) {
			countDownTimer -= Time.deltaTime;
			int timerInt = (int)Mathf.Round (countDownTimer);
			timerLb.text = (timerInt-1).ToString ();
			if(timerInt == 1){
				timerLb.text = "START";
			}else if(timerInt <= 0){
				COUNTDOWNING = false;
				timerLb.text = 0.ToString();
				bar.transform.Translate(10, 0, 0);
				subjectobj.transform.Translate (5.0f, 5, 0);
				timerLb.transform.Translate(-5,0,0);
				BarTimerBoo = true;
			}
		}
		if(BarTimerBoo){
			barTimer -= Time.deltaTime;
			barTimerLb.text = barTimer.ToString();
			barScale = barTimer / 20.0f;
			bar.transform.localScale = new Vector3 (barScale, 0.08f, 1.0f);
			if(barTimer <= 0){
				BarTimerBoo = false;
				bar.transform.Translate(-10, 0, 0);
				subjectobj.transform.Translate (5.0f, 5, 0);
				Debug.Log("AnswerStart");
				AnswerSelectButtonSet(playerNum);
			}
		}
	}

	void CountDownStart(int n){
		COUNTDOWNING = true;
		playerNum = n;
		Debug.Log (playerNum);
	}

	void AnswerSelectButtonSet(int n){
		if(n == 3){
			Dbt.transform.Translate(-100,0,0);
			Ebt.transform.Translate(-100,0,0);
			Fbt.transform.Translate(-100,0,0);
		}else if(n == 4){
			Ebt.transform.Translate(-100,0,0);
			Fbt.transform.Translate(-100,0,0);
		}else if(n == 5){
			Fbt.transform.Translate(-100,0,0);
		}
		answerSelect.transform.Translate (4.2f, -1.5f, 0.0f);
		answerController.SendMessage ("PlayerNumGet", playerNum);

	}
}
