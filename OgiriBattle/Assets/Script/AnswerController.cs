using UnityEngine;
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

	int answerNum = 1;
	int numA, numB, numC, numD, numE, numF;

	bool pushA = false, pushB = false, pushC = false, pushD = false, pushE = false, pushF = false;

	bool answerEnd = false;

	string[] ans;

	string[] mem = {"A","B","E","D","E","F"};

	int nowM;

	int playerNum;



	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}

	void AnswerA(){
		if(!pushA){
			numA = answerNum;
			answerNum ++;
			pushA = true;
			PersonalAnswer(0);
		}
	}
	void AnswerB(){
		if(!pushB){
			numB = answerNum;
			answerNum ++;
			pushB = true;
			PersonalAnswer(1);
		}
	}
	void AnswerC(){
		if(!pushC){
			numC = answerNum;
			answerNum ++;
			pushC = true;
			PersonalAnswer(2);
		}
	}
	void AnswerD(){
		if(!pushD){
			numD = answerNum;
			answerNum ++;
			pushD = true;
			PersonalAnswer(3);
		}
	}
	void AnswerE(){
		if(!pushE){
			numE = answerNum;
			answerNum ++;
			pushE = true;
			PersonalAnswer(4);
		}
	}
	void AnswerF(){
		if(!pushF){
			numF = answerNum;
			answerNum ++;
			pushF = true;
			PersonalAnswer(5);
		}
	}

	void AnswerCheck(int n){
		if(answerNum > n){
			answerEnd = true;
			Debug.Log("AllAnswerEnd");
		}
	}
	void AnswerOK(){
		answerSelect.transform.Translate (0, -10.0f, 0);
		personalAnswer.transform.Translate(0, -10.0f, 0);
		AnswerCheck (playerNum);
		ans [nowM] = input.text;
		personalAnswerTitleLb.text = ans [nowM];
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
	}


}
