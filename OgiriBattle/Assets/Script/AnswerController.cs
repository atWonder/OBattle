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

	bool answerEnd = false;

	int playerNum;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {

	}

	void AnswerA(){
		numA = answerNum;
		answerNum ++;
		AnswerCheck (playerNum);
	}
	void AnswerB(){
		numB = answerNum;
		answerNum ++;
		AnswerCheck (playerNum);
	}
	void AnswerC(){
		numC = answerNum;
		answerNum ++;
		AnswerCheck (playerNum);
	}
	void AnswerD(){
		numD = answerNum;
		answerNum ++;
		AnswerCheck (playerNum);
	}
	void AnswerE(){
		numE = answerNum;
		answerNum ++;
		AnswerCheck (playerNum);
	}
	void AnswerF(){
		numF = answerNum;
		answerNum ++;
		AnswerCheck (playerNum);
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
