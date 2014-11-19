using UnityEngine;
using System.Collections;

public class AnswerController : MonoBehaviour {

	public UIButton Abt;
	public UIButton Bbt;
	public UIButton Cbt;
	public UIButton Dbt;
	public UIButton Ebt;
	public UIButton Fbt;

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
			AnswerCheck (playerNum);
			pushA = true;
		}
	}
	void AnswerB(){
		if(!pushB){
			numB = answerNum;
			answerNum ++;
			AnswerCheck (playerNum);
			pushB = true;
		}
	}
	void AnswerC(){
		if(!pushC){
			numC = answerNum;
			answerNum ++;
			AnswerCheck (playerNum);
			pushC = true;
		}
	}
	void AnswerD(){
		if(!pushD){
			numD = answerNum;
			answerNum ++;
			AnswerCheck (playerNum);
			pushD = true;
		}
	}
	void AnswerE(){
		if(!pushE){
			numE = answerNum;
			answerNum ++;
			AnswerCheck (playerNum);
			pushE = true;
		}
	}
	void AnswerF(){
		if(!pushF){
			numF = answerNum;
			answerNum ++;
			AnswerCheck (playerNum);
			pushF = true;
		}
	}

	void AnswerCheck(int n){
		if(answerNum > n){
			answerEnd = true;
			Debug.Log("AllAnswerEnd");
		}
	}

	void PlayerNumGet(int n){
		playerNum = n;
	}
}
