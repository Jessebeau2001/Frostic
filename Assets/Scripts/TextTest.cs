﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class TextTest : MonoBehaviour {

	public Text myText;
	public float timeLeft;
	private bool stop = false;
	void Start ()
	{

	}
	
	void Update () {
		if (timeLeft >= 0 ) {
			timeLeft -= Time.deltaTime*10;
		}
		if (timeLeft >= 100) {
			myText.text = timeLeft.ToString("F0");
		} else if (timeLeft >= 10) {
			myText.text = "0" + timeLeft.ToString("F0");
		} else if (timeLeft >= 0) {
			myText.text = "00" + timeLeft.ToString("F0");
		} else {
			SceneManager.LoadScene("endScreen");
		}
			
	}
}
