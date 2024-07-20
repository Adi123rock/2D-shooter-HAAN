using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class forceapply : MonoBehaviour
{
    public float fwdForce=20f;
    public float sideForce=100f;
    public Rigidbody2D rb;
    void FixedUpdate()
    {
        
        if(Input.GetKey("w") ){
            rb.AddForce(new Vector2(0,fwdForce*Time.deltaTime));
        }
        else if(Input.GetKey("s") ){
            rb.AddForce(new Vector2(0,-fwdForce*Time.deltaTime));
        }
        if(Input.GetKey("d")){
            rb.AddForce(new Vector2(sideForce*Time.deltaTime,0),ForceMode2D.Force);
        }
        else if(Input.GetKey("a")){
            rb.AddForce(new Vector2(-sideForce*Time.deltaTime,0),ForceMode2D.Force);
        }        
    }
}