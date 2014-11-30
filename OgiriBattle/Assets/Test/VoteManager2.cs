using UnityEngine;
using System.Collections;

public class VoteManager2 : MonoBehaviour {

	int nowMen;
	public int playerNum = 6;
	int nowM;
	public UILabel answer0, answer1, answer2, answer3, answer4; 
	string[] ans = {"a","b","c","d","e","f"};
	public UILabel[] ansLb;
	bool forKey = false;

	int ran;
	int voteKey;
	int[] score;
	int playerKey;

	public int player;


	// Use this for initialization
	void Start () {
		ansLb = new UILabel[5];
		ansLb [0] = answer0;
		ansLb [1] = answer1;
		ansLb [2] = answer2;
		ansLb [3] = answer3;
		ansLb [4] = answer4;
		ran = Random.Range (0, playerNum-1);
		Debug.Log ("RANDOM NUMBER ::: " + ran);
		GoPersonalVotePage (player);
		score = new int[playerNum];


		for(int i = 0; i < 6-playerNum; i++){
			Destroy()
		}

	}

	// Update is called once per frame
	void Update () {

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

	}




	void Vote1(){
		Debug.Log ("I vote ::: "+ans[0]);
	}
	void Vote2(){
		Debug.Log ("I vote ::: "+ans[1]);
	}
	void Vote3(){
		Debug.Log ("I vote ::: "+ans[2]);
	}
	void Vote4(){
		Debug.Log ("I vote ::: "+ans[3]);
	}
	void Vote5(){
		Debug.Log ("I vote ::: "+ans[4]);
	}
}
