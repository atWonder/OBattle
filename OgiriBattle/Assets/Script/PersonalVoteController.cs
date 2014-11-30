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

	int ran;
	int voteKey;

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
	}

	void AnswerArrGet(string[] a){
		ans = a;
	}

	void GoPersonalVotePage(int n){
		nowM = n;
		voteKey = ran;
		for(int i = 0; i < playerNum; i++){
			Debug.Log(i.ToString());
			if (voteKey == playerNum-1) {
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
		
	}

	void Vote2(){
	
	}

	void Vote3(){
	
	}

	void Vote4(){
		
	}

	void Vote5(){
	
	}

}
