using UnityEngine;
using System.Collections;

public class GhostPathJunction : MonoBehaviour {

    public GhostPathJunction[] neighbours;
    private System.Random rnd;
    private MeshRenderer msh;

	// Use this for initialization
	void Start () {
        rnd = new System.Random();
        msh = GetComponent<MeshRenderer>();
        msh.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	}

    public GhostPathJunction getNextJunction(){
        return neighbours[rnd.Next(0,neighbours.Length)];  //TODO pick a random one
    }
}
