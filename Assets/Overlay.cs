using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class Overlay : MonoBehaviour {

    public StartOverlay startOverlay;
    public ScoreText scoreOverlay;
    public GameOverLay gameOverLay;
    public WinOverlay winOverlay;

	// Use this for initialization
	void Start () {
        gameOverLay.gameObject.SetActive(false);
        winOverlay.gameObject.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    public void updateScore(int score)
    {
        scoreOverlay.updateScore(score);
        startOverlay.gameObject.SetActive(false);
    }

    public void setInitialScore(int score)
    {
        scoreOverlay.updateScore(score);
    }

    public void gameOver()
    {
        scoreOverlay.gameObject.SetActive(false);
        gameOverLay.gameObject.SetActive(true);
    }

    public void win()
    {
        scoreOverlay.gameObject.SetActive(false);
        winOverlay.gameObject.SetActive(true);
    }

    public void restartGame()
    {
        SceneManager.LoadScene("whatwasthis");
    }
}
