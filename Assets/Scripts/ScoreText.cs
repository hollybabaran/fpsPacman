using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {

    // Use this for initialization
    private Text scoreText;
    private int totalPickups;
    private int score; 
    public PickupsRemaining pickupsRemaining;

    void Start () {
        scoreText = GetComponent<Text>();
        totalPickups = pickupsRemaining.getPickupsRemaining();
        score = 0;
    }
	
	// Update is called once per frame
	void LateUpdate () {
        scoreText.text = (totalPickups - score) + " to go...";
	}

    public void updateScore(int score)
    {
        this.score = score; 
    }
}
