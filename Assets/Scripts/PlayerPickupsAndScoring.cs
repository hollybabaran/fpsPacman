using UnityEngine;
using System.Collections;

public class PlayerPickupsAndScoring : MonoBehaviour {

    public Overlay overlay;
    private int score;

    // Use this for initialization
    void Start(){
        score = 0;
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pickup")){
            eatPickup(other);
        }
        if (other.gameObject.CompareTag("Ghost")){
            //BroadcastMessage or SendMessage game over 
        }
    }

    void eatPickup(Collider other){
        other.gameObject.SetActive(false);
        score++;
        overlay.updateScore(score);
    }

}
