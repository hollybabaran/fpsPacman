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
        GhostPathJunction[] tmp = new GhostPathJunction[];
        foreach(GhostPathJunction n in neighbours)
        {
            if(n!= null)
            {
                 
            }
        }
            
            
           // (c => c != null).ToArray();
    }
	
	// Update is called once per frame
	void Update () {
	}

    public GhostPathJunction getNextJunction(GhostPathJunction prevJunc){
        GhostPathJunction g = prevJunc;
        while(neighbours.Length > 1 && g == prevJunc){
            g = neighbours[rnd.Next(0, neighbours.Length)]; //allow for "None" in the scene, just reroll
        }
        return g;
    }
}
