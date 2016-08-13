using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverLay : MonoBehaviour {

    public Overlay overlay;
    private Text gameOverText;
    private int finalScore; 
    // Use this for initialization
    void Start () {
	    gameOverText = GetComponentInChildren<Text>();
        finalScore = -1; 
    }
	
	// Update is called once per frame
	void Update () {
        if (finalScore == -1) setFinalScore();
        setGameOverMessage();
        if (Input.GetKeyDown("space")) {
            overlay.restartGame();
        }
    }

    public void setFinalScore()
    {
        finalScore = overlay.scoreOverlay.getDisplay();
    }

    void setGameOverMessage() {
        gameOverText.text = "wakwak.\n";
        gameOverText.text += "there were " + finalScore + " candies left\n";
        gameOverText.text += "not bad!\n"; //TODO customize this message based on score 
        gameOverText.text += "space to play again";
    }
}
