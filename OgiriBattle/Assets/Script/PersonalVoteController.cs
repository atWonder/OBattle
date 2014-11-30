using UnityEngine;
using System.Collections;

public class PersonalVoteController : MonoBehaviour {


	public GameObject personalVote;
	public GameObject answerSelect;

	int nowMen;
	int playerNum;
	int nowM;
	public UILabel answer0, answer1, answer2, answer3, answer4; 
	string[] ans;
	public UILabel[] ansLb;
	bool forKey = false;
	int playerKey;

	int ran;
	int voteKey;
	int[] score;

	// Use this for initialization
	void Start () {
		ansLb = new UILabel[5];
		ansLb [0] = answer0;
		ansLb [1] = answer1;
		ansLb [2] = answer2;
		ansLb [3] = answer3;
		ansLb [4] = answer4;



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
	}

	void GoPersonalVotePage(int n){
		nowM = n;
		voteKey = ran;
		if (ran > 5 - nowM) {
			playerKey = playerNum-1;
		} else {
			playerKey = playerNum;
		}
		for(int i = 0; i < playerNum; i++){
			//Debug.Log(i.ToString());
			if (voteKey == playerKey) {
				if(!forKey){
					voteKey = 0;
				}else{
					voteKey = 1;
				}
			}
			if(i == nowM){
				forKey = true;
			}else{
				if(!forKey){
					ansLb[voteKey].text = ans[i];
				}else{
					ansLb[voteKey-1].text = ans[i];
				}
			}

			voteKey++;

		}
		personalVote.transform.Translate (-11, 0, 0);
		answerSelect.transform.Translate (-11, 0, 0);
		Debug.Log ("GoPersonalPage" + nowM.ToString ());
	}

	void Vote1(){
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
