using UnityEngine;
using System.Collections;

public class PlayerPickupsAndScoring : MonoBehaviour {

    public Overlay overlay;
    private int remaining;
    public PickupsRemaining pickupsRemaining;
    private int totalPickups;

    // Use this for initialization
    void Start(){
        remaining = pickupsRemaining.getPickupsRemaining();
        overlay.setInitialScore(remaining);
    }

    void OnTriggerEnter(Collider other){
        if (other.gameObject.CompareTag("Pickup")){
            eatPickup(other);
        }
        if (other.gameObject.CompareTag("Ghost")){
            overlay.gameOver(); 
        }
    }

    void eatPickup(Collider other){
        other.gameObject.SetActive(false);
        remaining--;
        overlay.updateScore(remaining);
        if (remaining < 170) //TODO change to ==0
        {
            overlay.win();
        }
    }


}
