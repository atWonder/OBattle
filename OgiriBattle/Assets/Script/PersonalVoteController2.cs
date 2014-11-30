using UnityEngine;
using System.Collections;

public class PersonalVoteController2 : MonoBehaviour {

	public GameObject personalVote;
	public GameObject answerSelect;

	int nowMen;
	int playerNum;
	int nowM;
	public UILabel answer0, answer1, answer2, answer3, answer4, answer5;
	public UIButton ansBt0, ansBt1, ansBt2, ansBt3, ansBt4, ansBt5;
	UILabel[] ansLb;
	UIButton[] ansBtArr;

	string[] ans;
	bool forKey = false;
	int playerKey;

	int ran;
	int voteKey;
	int[] score;

	// Use this for initialization
	void Start () {
		ansLb = new UILabel[6];
		ansBtArr = new UIButton[6];

		ansLb [0] = answer0;
		ansLb [1] = answer1;
		ansLb [2] = answer2;
		ansLb [3] = answer3;
		ansLb [4] = answer4;
		ansLb [5] = answer5;

		ansBtArr [0] = ansBt0;
		ansBtArr [1] = ansBt1;
		ansBtArr [2] = ansBt2;
		ansBtArr [3] = ansBt3;
		ansBtArr [4] = ansBt4;
		ansBtArr [5] = ansBt5;

	}

	// Update is called once per frame
	void Update () {

	}

	void PlayerNumGet(int n){
		playerNum = n;
		Debug.Log ("PersonalAnswerGetting" + playerNum.ToString ());
		ran = Random.Range (0,playerNum-1);
		Debug.Log ("RandomNumber:::" + ran.ToString ());
		score = new int[playerNum];
	}

	void AnswerArrGet(string[] a){
		ans = a;
		for (int i = 0; i < a.Length; i++) {
			ansLb [i].text = ans [i];
			Debug.Log (i.ToString ());
		}
		for(int i = 0; i < 6-a.Length; i++){
			Destroy (ansBtArr [5 - i].gameObject);
		}
	}

	void GoPersonalVotePage(int n){
		ansBtArr [n].gameObject.transform.Translate (11, 0, 0);



		personalVote.transform.Translate (-11, 0, 0);
		answerSelect.transform.Translate (-11, 0, 0);
		Debug.Log ("GoPersonalPage" + nowM.ToString ());
	}

	void Vote1(){
		//ansLb[0+ran]
		ReturnVoteSelect ();
	}

	void Vote2(){
		ReturnVoteSelect ();
	}

	void Vote3(){
		ReturnVoteSelect ();
	}

	void Vote4(){
		ReturnVoteSelect ();
	}

	void Vote5(){
		ReturnVoteSelect ();
	}

	void AttachAnsM(){

	}
	void ReturnVoteSelect(){
		forKey = false;
		personalVote.transform.Translate (11, 0, 0);
		answerSelect.transform.Translate (11, 0, 0);

	}

}
