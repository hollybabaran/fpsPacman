﻿using UnityEngine;
using System.Collections;

public class StartOverlay : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void pickOneUp()
    {
        this.gameObject.SetActive(false);
    }
}
