using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss_damage : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D collisioninfo)
    {
        if(collisioninfo.tag=="PlyBullet")
        {
            FindObjectOfType<Boss>().dec_hbar();
        }
    }
}
