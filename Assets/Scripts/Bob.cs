using UnityEngine;
using UnityStandardAssets.Utility;

public class Bob : MonoBehaviour
{
    private Rigidbody rb;
    public float amplitude;
    public float duration;
    
    private bool direction; //true for going up 
    private float time; 
    // Update is called once per frame
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        direction = true;
        time = 0f; 
    }

    void FixedUpdate()
    {
        float t = Time.deltaTime;
        time += t;
        if (time > duration){
            direction = !direction;
            time = 0; 
        }
        Vector3 pos = rb.position;
        pos.y += getOffset(t);
        rb.MovePosition(pos);
    }

    //returns a positive offset if going up, negative if going down 
    private float getOffset(float t){
        float offset = (amplitude / duration) * t;
        offset = direction ? offset : -1 * offset; 
        return offset; 
    }
}
