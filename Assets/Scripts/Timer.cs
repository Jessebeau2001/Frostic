﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
	public Text uiText;
	public float mainTimer;

	private float timer;
	private bool canCount = true;
	private bool doOnce = false;
	void start()
	{
		uiText.text = "test";
		// timer = mainTimer;
	}

	void update()
	{

		// if (timer >= 0.0f && canCount) {
		// 	timer -= Time.deltaTime;
		// 	uiText.text = timer.ToString("F");
		// } else if (timer <= 0.0f && !doOnce) {
		// 	canCount = false;
		// 	doOnce = true;
		// 	uiText.text = "0.00";
		// 	timer = 0.0f;
		// }
	}
}
