using UnityEngine;
using System.Collections;
using UnityStandardAssets.Utility;

public class Rotator : MonoBehaviour {

    //public float bobSpeed;
    public LerpControlledBob bob = new LerpControlledBob();

    // Update is called once per frame
    void Update () {
        StartCoroutine(bob.DoBobCycle());
    }
}
