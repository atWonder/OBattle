using UnityEngine;
using System.Collections;

public class VoteManager : MonoBehaviour {
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

	public int player;

	// Use this for initialization
	void Start () {
		ansLb = new UILabel[5];
		ansLb [0] = answer0;
		ansLb [1] = answer1;
		ansLb [2] = answer2;
		ansLb [3] = answer3;
		ansLb [4] = answer4;
		ran = Random.Range (0, playerNum);
		Debug.Log ("RANDOM NUMBER ::: " + ran);
		GoPersonalVotePage (player);
	}
	
	// Update is called once per frame
	void Update () {
	
	}


	void GoPersonalVotePage(int n){
		nowM = n;
		voteKey = ran;
		for(int i = 0; i < playerNum; i++){
			Debug.Log(i.ToString());
			if (voteKey == playerNum) {
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
}
