using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class WinOverlay : MonoBehaviour
{

    public Overlay overlay;

    private Text WinText;
    // Use this for initialization
    void Start()
    {
        WinText = GetComponentInChildren<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        setWinMessage();
        if (Input.GetKeyDown("space"))
        {
            overlay.restartGame();
        }

    }

    void setWinMessage()
    {
        WinText.text = ":O\n";
        WinText.text += "you won!\n";
        WinText.text += "you ain't afraid of no ghosts.\n"; 
        WinText.text += "Don't hit space, go outside";
        //TODO give them a dancing banana gif or something 
    }
}
