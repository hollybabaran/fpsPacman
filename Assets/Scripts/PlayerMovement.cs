using UnityEngine;
using System.Collections;

public class PlayerMovement : MonoBehaviour {

    private Rigidbody rb;
    //public vars are modified on-screen in unity
    public float forwardSpeed; 
    public float strafeSpeed;
    public float collisionCheckDistance;

    // Use this for initialization
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
	
	// Update is called once per frame
	void FixedUpdate () {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        //rb.moveRotation on camera
        Vector3 movement = new Vector3(moveHorizontal*strafeSpeed, 0.0f, moveVertical*forwardSpeed);
        RaycastHit hit;
        if (!rb.SweepTest(movement, out hit, collisionCheckDistance)){
            rb.MovePosition(rb.position + movement);
        }
        else{
            rb.MovePosition(hit.point);
        }
        
    }


    void OnTriggerEnter(Collider other)
    {
        //if (other.gameObject.CompareTag("Wall"))
        //{
        //    rb.MovePosition(rb.position);
        //}
    }
}

//for pickups: other.gameObject.SetActive(false);