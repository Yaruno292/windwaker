﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RupeeUI : MonoBehaviour {

    public Text scoreText;
    public static int Rupee = 0;

    // Update is called once per frame
    void Update () {
        scoreText.text = "" + Rupee;
	}
}
