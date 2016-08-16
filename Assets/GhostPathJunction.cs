using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class GhostPathJunction : MonoBehaviour {

    public List<GhostPathJunction> neighbours;
    private System.Random rnd;
    private MeshRenderer msh;

	// Use this for initialization
	void Start () {
        rnd = new System.Random();
        msh = GetComponent<MeshRenderer>();
        msh.enabled = false;
        neighbours.RemoveAll(item => item == null);
    }
	
	// Update is called once per frame
	void Update () {
	}

    public GhostPathJunction getNextJunction(GhostPathJunction prevJunc){
        GhostPathJunction g = prevJunc;
        //at the start, pick any of the neighbours b/c prevJunc is null
        //otherwise pick from the neighbours that aren't prevJunc, unless you're at a dead end
        while (g == null || (g == prevJunc && neighbours.Count > 1)){ 
            g = neighbours[rnd.Next(0, neighbours.Count)];
        }
        return g;
    }
}
