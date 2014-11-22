using UnityEngine;
using System.Collections;

public class AnswerController : MonoBehaviour {

	public UIButton Abt;
	public UIButton Bbt;
	public UIButton Cbt;
	public UIButton Dbt;
	public UIButton Ebt;
	public UIButton Fbt;

	public UILabel personalAnswerTitleLb;

	public GameObject answerSelect;
	public GameObject personalAnswer;

	int answerNum = 1;
	int numA, numB, numC, numD, numE, numF;

	bool pushA = false, pushB = false, pushC = false, pushD = false, pushE = false, pushF = false;

	bool answerEnd = false;

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
			PersonalAnswer("A");
		}
	}
	void AnswerB(){
		if(!pushB){
			numB = answerNum;
			answerNum ++;
			pushB = true;
			PersonalAnswer("B");
		}
	}
	void AnswerC(){
		if(!pushC){
			numC = answerNum;
			answerNum ++;
			pushC = true;
			PersonalAnswer("C");
		}
	}
	void AnswerD(){
		if(!pushD){
			numD = answerNum;
			answerNum ++;
			pushD = true;
			PersonalAnswer("D");
		}
	}
	void AnswerE(){
		if(!pushE){
			numE = answerNum;
			answerNum ++;
			pushE = true;
			PersonalAnswer("E");
		}
	}
	void AnswerF(){
		if(!pushF){
			numF = answerNum;
			answerNum ++;
			pushF = true;
			PersonalAnswer("F");
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
	}

	void PersonalAnswer(string m){
		personalAnswerTitleLb.text = m + "さんの回答です";
		answerSelect.transform.Translate (0, 10.0f, 0);
		personalAnswer.transform.Translate(0, 10.0f, 0);
	}

	void PlayerNumGet(int n){
		playerNum = n;
	}


}
