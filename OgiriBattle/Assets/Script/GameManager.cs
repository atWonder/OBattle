using UnityEngine;
using System.Collections;

public class GameManager : MonoBehaviour {

	private int playerNum = 0;
	public UIButton bt3;
	public UIButton bt4;
	public UIButton bt5;
	public UIButton bt6;
	public UILabel PlayerSelectConfirmMes;

	public GameObject PlayerSelectObj;

	public int SLIDESPEED;
	public float SLIDEDIS;
	float timer;

	bool GAMESTART = false;
	bool CONFIRM = false;

	bool SLIDING = false;
	// Use this for initialization
	void Start () {
		timer = SLIDEDIS;
	}
	
	// Update is called once per frame
	void Update () {
		SlideOut ();
		if(playerNum == 999){

		}else if(playerNum != 0){
			PlayerSelectConfirmMes.text = playerNum + "人で開始します\nよろしいですか？";
		}
	}

	void PlayerSelect3(){
		Debug.Log("3Player");
		playerNum = 3;
		SLIDING = true;
	}
	void PlayerSelect4(){
		Debug.Log("4Player");
		playerNum = 4;
		SLIDING = true;
	}
	void PlayerSelect5(){
		Debug.Log("5Player");
		playerNum = 5;
		SLIDING = true;
	}
	void PlayerSelect6(){
		Debug.Log("6Player");
		playerNum = 6;
		SLIDING = true;
	}

	void ReturnSelect(){
		Debug.Log("Return");
		FadeManager.Instance.LoadLevel("LocalGame",1.5f);
	}

	void ConfirmSelect(){
		SLIDING = true;
		CONFIRM = true;
	}

	void SlideOut(){
		if(playerNum != 0){
			if(SLIDING){
				timer -= Time.deltaTime;
				PlayerSelectObj.transform.Translate (-Time.deltaTime*SLIDESPEED, 0, 0);
				Debug.Log(Time.deltaTime);
				if(timer<= 0.0f){
					SLIDING = false;
					timer = SLIDEDIS;
					if(CONFIRM){
						GAMESTART = true;
						Debug.Log("gameStart");
					}
				}

			}else{
			}
		}
	}
}
