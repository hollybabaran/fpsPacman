using UnityEngine;
using System.Collections;

public class PickupsRemaining : MonoBehaviour {
   

    // Use this for initialization
    void Start () {
        
    }
	
	// Update is called once per frame
	void Update () {
	
	}

    //count pickups every time. Inefficient, but more extensible
    public int getPickupsRemaining()
    {
        int remaining = 0;
        foreach (Rigidbody pickup in GetComponentsInChildren<Rigidbody>())
        {
            if (pickup.gameObject.activeSelf)
            {
                remaining++;
            }
        }
        return remaining;
    }
}
