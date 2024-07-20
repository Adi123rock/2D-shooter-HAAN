using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bulletdestroy : MonoBehaviour
{

    void OnTriggerEnter2D(Collider2D collisionInfo){
        if(collisionInfo.tag=="Bullet"){
            Destroy(collisionInfo.gameObject);
        }


    }
}