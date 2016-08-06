using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class Bob : MonoBehaviour
{
    private Rigidbody rb;
    public LerpControlledBob bob = new LerpControlledBob();

    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        StartCoroutine(bob.DoBobCycle());
    }

    void FixedUpdate()
    {
        Vector3 pos = rb.position;
        pos.y += bob.Offset();
        print(pos.y);
        rb.MovePosition(pos);
        StartCoroutine(bob.DoBobCycle());
    }
}
