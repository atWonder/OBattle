﻿using UnityEngine;
using System.Collections;

public class DialogFade : MonoBehaviour {
	public float fadeTime = 11f;
	
	private float currentRemainTime;
	private SpriteRenderer spRenderer;
	
	// Use this for initialization
	void Start () {
		// 初期化
		currentRemainTime = fadeTime;
		spRenderer = GetComponent<SpriteRenderer>();
	}
	
	// Update is called once per frame
	void Update () {
		// 残り時間を更新
		currentRemainTime -= Time.deltaTime;
		
		if ( currentRemainTime <= 0f ) {
			// 残り時間が無くなったら自分自身を消滅
			GameObject.Destroy(gameObject);
			return; 
		}
		
		// フェードアウト
		float alpha = currentRemainTime / fadeTime;
		Color color = spRenderer.color;
		color.a = alpha;
		spRenderer.color = color;
	}

}
