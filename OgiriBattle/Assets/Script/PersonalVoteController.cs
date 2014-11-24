using UnityEngine;
using System.Collections;

public class PersonalVoteController : MonoBehaviour {

	int playerNum;
	int nowMem;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void PlayerNumGet(int n){
		playerNum = n;
		Debug.Log ("PersonalAnswerGetting" + playerNum.ToString ());
	}
}
