using UnityEngine;
using System.Collections;

public class ScoreText : MonoBehaviour {

    // Use this for initialization
    private GUIText scoreText; 

	void Start () {
        scoreText = GetComponent<GUIText>();
	}
	
	// Update is called once per frame
	void Update () {
        scoreText.text = "candies remaining: ";
	}
}
