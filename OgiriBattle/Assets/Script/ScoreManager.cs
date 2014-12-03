using UnityEngine;
using System.Collections;

public class ScoreManager : MonoBehaviour {



	string[] ans;
	int[] score;
	int playerNum;
	int[] rank;
	int[] idx;
	string[] memAl = { "A", "B", "C", "D", "E", "F" };
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	void GetPlayerNum(int n){
		playerNum = n;
		rank = new int[playerNum];
		idx = new int[playerNum];
	}

	void GetScoreArr(int[] s){
		score = s;
	}

	void GetAnsArr(string[] a){
		ans = a;
	}

	void ScoreSort(){
		for (int i = 0; i < playerNum; i++) {
			rank[i] = 1;
		}
		for (int i = 1; i < playerNum; i++) {
			for (int j = 0; j <=i-1; j++) {
				if (score[j]>score[i])rank[i]++;
				if (score[j]<score[i])rank[j]++;
			}
		}
		for(int i = 0; i < playerNum; i++){
			Debug.Log (rank [i]);
		}
		for (int i = 0; i < playerNum; i++) {
			if (rank [i] == 1) {
				idx [0] = i;
			} else {
			}
		}

		Debug.Log ("Winner is ..." + memAl [idx [0]]);

	}
}
