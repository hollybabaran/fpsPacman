using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class GameOverLay : MonoBehaviour {

    public Overlay overlay;

    private Text gameOverText;
    // Use this for initialization
    void Start () {
	    gameOverText = GetComponentInChildren<Text>();
    }
	
	// Update is called once per frame
	void Update () {
        setGameOverMessage();
        if (Input.GetKeyDown("space")) {
            overlay.restartGame();
        }
            
    }

    void setGameOverMessage(){
        gameOverText.text = "wakwak.\n";
        gameOverText.text += "there were " + overlay.scoreOverlay.getDisplay() + " candies left\n";
        gameOverText.text += "not bad!\n"; //TODO customize this message based on score 
        gameOverText.text += "space to play again";
    }
}
