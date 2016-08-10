using UnityEngine;
using System.Collections;

public class Overlay : MonoBehaviour {

    public StartOverlay startOverlay;
    public ScoreText scoreOverlay; 

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void updateScore(int score)
    {
        scoreOverlay.updateScore(score);
        startOverlay.pickOneUp();
    }
}
