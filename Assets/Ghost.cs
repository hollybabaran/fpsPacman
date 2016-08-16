using UnityEngine;
using System.Collections;

public class Ghost : MonoBehaviour {
    
    public GhostPathJunction currentJunction;
    public float speed;

    private bool moving;
    private Vector3 startPos;
    private Vector3 destPos;
    private GhostPathJunction prevJunction;
    private Vector3 distanceBetweenJunctions; 

	// Use this for initialization
	void Start () {
        moving = false;
        transform.position = currentJunction.transform.position;

    }
	
	// Update is called once per frame
	void Update () {
        if (!moving){
            goToNextJunction();  
        } else{
            move(); 
        }
	}

    void goToNextJunction(){
        GhostPathJunction tmp = currentJunction.getNextJunction(prevJunction);
        prevJunction = currentJunction;
        currentJunction = tmp;
        moving = true;
    }

    void move(){
        float step = speed * Time.deltaTime;
        transform.position = Vector3.MoveTowards(transform.position, currentJunction.transform.position, step);
        if (transform.position == currentJunction.transform.position) {
            moving = false;
        }
    }

}
