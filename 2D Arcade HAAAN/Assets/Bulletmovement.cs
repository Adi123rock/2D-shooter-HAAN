using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bulletmovement : MonoBehaviour
{
    public int speed = 20;
    public Rigidbody2D bullet ;
    void Start()
    {
        bullet.velocity = transform.right *speed ;       
    }

}
