using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class forceapply : MonoBehaviour
{
    //bool Fwd=true;
    //public Vector3 explosionPosition;
    public float fwdForce=20f;
    public float sideForce=100f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }
    // Update is called once per frame
    void FixedUpdate()
    {
        
        if(Input.GetKey("w") ){
            rb.AddForce(new Vector2(0,fwdForce*Time.deltaTime));
        }
        else if(Input.GetKey("s") ){
            rb.AddForce(new Vector2(0,-fwdForce*Time.deltaTime));
        }
        //rb.AddExplosionForce(20,explosionPosition,2);
        if(Input.GetKey("d")){
            rb.AddForce(new Vector2(sideForce*Time.deltaTime,0));
        }
        else if(Input.GetKey("a")){
            rb.AddForce(new Vector2(-sideForce*Time.deltaTime,0));
        }
        
    }
}
