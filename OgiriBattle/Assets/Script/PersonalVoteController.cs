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
	}

	void AnswerArrGet(string[] a){
		ans = a;
	}

	void GoPersonalVotePage(int n){
		nowM = n;

		for(int i = 0; i < playerNum; i++){
			Debug.Log(i.ToString());
			if(i == nowM){
				forKey = true;
			}else{
				if(!forKey){
					ansLb[i].text = ans[i];
				}else{
					ansLb[i-1].text = ans[i];
				}
			}
		}

		personalVote.transform.Translate (-11, 0, 0);
		answerSelect.transform.Translate (-11, 0, 0);
		Debug.Log ("GoPersonalPage" + nowM.ToString ());
	}

	void TestTouch(){
		Debug.Log("VoteComplete");
	}

	 

}
