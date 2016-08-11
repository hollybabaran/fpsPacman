using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class ScoreText : MonoBehaviour {

    // Use this for initialization
    private Text scoreText;
    private int score; 

    void Start () {
        scoreText = GetComponent<Text>();
    }
	
	// Update is called once per frame
	void LateUpdate () {
        scoreText.text = score + " to go...";
	}

    public void updateScore(int score)
    {
        this.score = score; 
    }
    
    public int getDisplay()
    {
        return score; 
    }
}
