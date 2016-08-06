using UnityEngine;
using System.Collections;

public class PlayerPickupsAndScoring : MonoBehaviour {

    private Rigidbody m_RigidBody;

    // Use this for initialization
    private void Start()
    {
        m_RigidBody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update () {
	
	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Pickup"))
        {
            other.gameObject.SetActive(false);
        }
    }
}
