﻿using UnityEngine;
using System.Collections;

public class GameScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
        FutileParams futileParams = new FutileParams(true, false, false, false);
        futileParams.AddResolutionLevel(160.0f, 1.0f, 1.0f, ""); // Gameboy resolution 160x144px

        futileParams.origin = new Vector2(0.5f, 0.5f);
        futileParams.backgroundColor = new Color(0, 0, 0);
        futileParams.shouldLerpToNearestResolutionLevel = true;

        Futile.instance.Init(futileParams);

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}