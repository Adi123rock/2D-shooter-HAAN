using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class Obstaclefiring : MonoBehaviour
{
    public int blts_no;
    int i=0;
    public Transform wrt_camera,enb;
    public float enbforce;
    public GameObject enblt;


    // Update is called once per frame
    void Start()
    {
        //if(transform.position.y<(wrt_camera.position.y+9))
        //{
            // enb.position=transform.position;
            // enblt.AddForce(new Vector2(0,-enbforce*Time.deltaTime));
            //i++;
        //}
        
    }

    void FixedUpdate()
    {
        //-4 since camera position 4 ahead of player
        // if(transform.position.y>wrt_camera.position.y-4 && enb.position.y<(transform.position.y-9) && transform.position.y<(wrt_camera.position.y+9-4))
        // {
        //     enblt.AddForce(new Vector2(0,enbforce*Time.deltaTime));
        //     //enblt.AddForce(0,enbforce*Time.deltaTime,0,ForceMode.VelocityChange);
        //     enb.position=transform.position;
        //     //enblt.AddForce(0,-enbforce*Time.deltaTime,0,ForceMode.VelocityChange);
        //     enblt.AddForce(new Vector2(0,-enbforce*Time.deltaTime));
        // }
        
        // else if(i==0 && transform.position.y>wrt_camera.position.y-4 && transform.position.y<(wrt_camera.position.y+9-4))
        // {
        //     i++;
            
        //     enb.position=transform.position;
        //     enblt.AddForce(new Vector2(0,-enbforce*Time.deltaTime));
        //     //enblt.AddForce(0,-enbforce*Time.deltaTime,0,ForceMode.VelocityChange);
        // }
        // remainingtime = remainingtime - Time.deltaTime ;
        // if(remainingtime<= 0){
        //     firedblt = Instantiate(enblt , firepoint.position , firepoint.rotation);
        //     remainingtime = 3f ;
        // }
    }
    //transform.position.y>player.position.y && enb.position.y<player.position.y

}
