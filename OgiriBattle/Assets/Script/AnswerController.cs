﻿using UnityEngine;
using System.Collections;

public class AnswerController : MonoBehaviour {

	public UIButton Abt;
	public UIButton Bbt;
	public UIButton Cbt;
	public UIButton Dbt;
	public UIButton Ebt;
	public UIButton Fbt;

	public UIInput input;

	public UILabel personalAnswerTitleLb;

	public GameObject answerSelect;
	public GameObject personalAnswer;

	public GameObject personalVoteController;

	int buttonPusher;

	int answerNum = 1;

	bool pushA = false, pushB = false, pushC = false, pushD = false, pushE = false, pushF = false;

	bool answerEnd = false;
	//ANSWER
	string[] ans;
	//NUMBER
	int[] num;

	string[] mem = {"A","B","C","D","E","F"};

	int state;
	int ANSWER = 0;
	int VOTE = 1;

	int nowM;

	int playerNum;



	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}

	void AnswerA(){
		buttonPusher = 0;
		if (state == ANSWER) {
			if(!pushA){
				num[buttonPusher] = answerNum;
				answerNum ++;
				pushA = true;
				PersonalAnswer(buttonPusher);
			}	
		}else if(state == VOTE){
			personalVoteController.SendMessage("GoPersonalVotePage", buttonPusher);
		}
	}
	void AnswerB(){
		buttonPusher = 1;
		if (state == ANSWER) {
			if(!pushB){
				num[buttonPusher] = answerNum;
				answerNum ++;
				pushB = true;
				PersonalAnswer(buttonPusher);
			}
		}else if(state == VOTE){
			Debug.Log("VOTE CLICK");
		}
	}
	void AnswerC(){
		buttonPusher = 2;
		if (state == ANSWER) {
			if(!pushC){
				num[buttonPusher] = answerNum;
				answerNum ++;
				pushC = true;
				PersonalAnswer(buttonPusher);
			}
		}else if(state == VOTE){
			Debug.Log("VOTE CLICK");
		}
	}
	void AnswerD(){
		buttonPusher = 3;
		if (state == ANSWER) {
			if(!pushD){
				num[buttonPusher] = answerNum;
				answerNum ++;
				pushD = true;
				PersonalAnswer(buttonPusher);
			}
		}else if(state == VOTE){
			Debug.Log("VOTE CLICK");
		}
	}
	void AnswerE(){
		buttonPusher = 4;
		if (state == ANSWER) {
			if(!pushE){
				num[buttonPusher] = answerNum;
				answerNum ++;
				pushE = true;
				PersonalAnswer(buttonPusher);
			}
		}else if(state == VOTE){
			Debug.Log("VOTE CLICK");
		}
	}
	void AnswerF(){
		buttonPusher = 5;
		if (state == ANSWER) {
			if(!pushF){
				num[buttonPusher] = answerNum;
				answerNum ++;
				pushF = true;
				PersonalAnswer(buttonPusher);
			}
		}else if(state == VOTE){
			Debug.Log("VOTE CLICK");
		}
	}

	void AnswerCheck(int n){
		if(answerNum > n){
			answerEnd = true;
			Debug.Log("AllAnswerEnd");
			state = VOTE;
			personalVoteController.SendMessage ("PlayerNumGet", playerNum);
			personalVoteController.SendMessage("AnswerArrGet", ans);
		}
	}
	void AnswerOK(){
		answerSelect.transform.Translate (0, -10.0f, 0);
		personalAnswer.transform.Translate(0, -10.0f, 0);
		AnswerCheck (playerNum);
		ans [nowM] = input.text;
		input.text = "ボケを入力！";
	}

	void PersonalAnswer(int m){
		personalAnswerTitleLb.text = mem[m] + "さんの回答です";
		answerSelect.transform.Translate (0, 10.0f, 0);
		personalAnswer.transform.Translate(0, 10.0f, 0);
		nowM = m;
	}

	void PlayerNumGet(int n){
		playerNum = n;
		ans = new string[n];
		num = new int[n];

	}

	void goToVote(int nowMem){

	}



}
