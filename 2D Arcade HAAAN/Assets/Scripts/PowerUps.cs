using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUps : MonoBehaviour
{
    public GameObject Shield;
    void OnTriggerEnter2D(Collider2D collisioninfo)
    {
        if(collisioninfo.tag=="Player")
        {
            //Destroy(Shield);
            // FindObjectOfType<PlayerCollisiion>().enabled=false;
            PlayerCollisiion.shield=false;
            Debug.Log("Shield On");
            Invoke("Shieldoff",10f);
            
        }
    }
    void Shieldoff()
    {
        PlayerCollisiion.shield=true;
        // FindObjectOfType<PlayerCollisiion>().enabled=true;
        Debug.Log("Shield off");
    }
}
