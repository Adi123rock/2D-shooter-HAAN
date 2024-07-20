using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class fireingbutton : MonoBehaviour
{
    public GameObject bullet,firedblt;
    public float firingspeedplayer;
    public Vector3 offset;
    public Transform player,bullt;
    public Rigidbody2D blt;
    void Start()
    {
    }
    // void FixedUpdate()
    // {
    //     if(Input.GetKey(KeyCode.Space))
    //     {
    //         Fire();
    //     }
    // }
    public void Fire(){
        Debug.Log("FIRE");
        firedblt=Instantiate(bullet,player.position+offset,player.rotation);
        blt=firedblt.GetComponent<Rigidbody2D>();
        Debug.Log(blt);
        if(blt!=null)
        {
            Debug.LogError("Yes Rigidbody component");
            firedblt.GetComponent<Rigidbody2D>().velocity=new Vector2(0f,10000f);
        }
        else
        {
            Debug.LogError("No Rigidbody component");
        }
        Debug.Log("passed");
        //blt.AddForce(new Vector2(0,100000));
        FindObjectOfType<AudioManager>().Play("Firing");
        //Instantiate(bullet);
        //bullt.position=player.position+offset;
        //blt.AddForce(0,10,0,ForceMode.VelocityChange);
        // firingspeedplayer*Time.deltaTime
    }
    /*
    void FixedUpdate(){
        blt.AddForce(0,2,0);
    }
    */
    
}
