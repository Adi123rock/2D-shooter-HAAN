using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mlp_blt_fire : MonoBehaviour
{
    Vector3 offset,offset2;
    public float firevelocity=5f; 
    public Transform player;
    float c_time = 0f, s_time = 0.1f;
    GameObject fired_blt1,fired_blt2,fired_blt3;
    public GameObject bullet;
    Transform firepoint;
    void Start()
    {
        offset.x=0.5f;
        offset.y=0;
        offset.z=0;
        offset2.x=0;
        offset2.y=0.5f;
        offset2.z=0;
    }
    void Update()
    {
        firepoint = FindObjectOfType<Boss>().firepoint.transform;
        //Debug.Log("DONE");
        c_time -= 1 * Time.deltaTime;
        if (c_time <= 0f)
        {
            attack();
        }
    }
    void attack()
    {
        c_time = s_time;
            if (player.position.x > 2)
            {
                if (player.position.y > 0)
                {
                    R90_firing();
                }
                else
                {
                    R45_firing();
                }
            }
            else if (player.position.x < -2)
            {
                if (player.position.y > 0)
                {
                    L90_firing();
                }
                else
                {
                    L45_firing();
                }
            }
            else
            {
                frontfiring();
            }
    }
    void stopfiring()
    {
        c_time = s_time;
    }
    void frontfiring()
    {
        // fired_blt1 = Instantiate(bullet, firepoint.position, firepoint.rotation);
        // fired_blt1.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -firevelocity);
        fired_blt2 = Instantiate(bullet, firepoint.position+offset, firepoint.rotation);
        fired_blt2.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -firevelocity);
        fired_blt3 = Instantiate(bullet, firepoint.position-offset, firepoint.rotation);
        fired_blt3.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -firevelocity);
        stopfiring();
    }
    void R45_firing()
    {
        // fired_blt1 = Instantiate(bullet, firepoint.position, firepoint.rotation);
        // fired_blt1.GetComponent<Rigidbody2D>().velocity = new Vector2(firevelocity, -firevelocity);
        fired_blt2 = Instantiate(bullet, firepoint.position+offset, firepoint.rotation);
        fired_blt2.GetComponent<Rigidbody2D>().velocity = new Vector2(firevelocity, -firevelocity);
        fired_blt3 = Instantiate(bullet, firepoint.position-offset, firepoint.rotation);
        fired_blt3.GetComponent<Rigidbody2D>().velocity = new Vector2(firevelocity, -firevelocity);
        stopfiring();
    }
    void R90_firing()
    {
        // fired_blt1 = Instantiate(bullet, firepoint.position, firepoint.rotation);
        // fired_blt1.GetComponent<Rigidbody2D>().velocity = new Vector2(firevelocity, 0f);
        fired_blt2 = Instantiate(bullet, firepoint.position+offset2, firepoint.rotation);
        fired_blt2.GetComponent<Rigidbody2D>().velocity = new Vector2(firevelocity, 0f);
        fired_blt3 = Instantiate(bullet, firepoint.position-offset2, firepoint.rotation);
        fired_blt3.GetComponent<Rigidbody2D>().velocity = new Vector2(firevelocity, 0f);
        stopfiring();
    }
    void L45_firing()
    {
        // fired_blt1 = Instantiate(bullet, firepoint.position, firepoint.rotation);
        // fired_blt1.GetComponent<Rigidbody2D>().velocity = new Vector2(-firevelocity, -firevelocity);
        fired_blt2 = Instantiate(bullet, firepoint.position+offset, firepoint.rotation);
        fired_blt2.GetComponent<Rigidbody2D>().velocity = new Vector2(-firevelocity, -firevelocity);
        fired_blt3 = Instantiate(bullet, firepoint.position-offset, firepoint.rotation);
        fired_blt3.GetComponent<Rigidbody2D>().velocity = new Vector2(-firevelocity, -firevelocity);
        stopfiring();
    }
    void L90_firing()
    {
        // fired_blt1 = Instantiate(bullet, firepoint.position, firepoint.rotation);
        // fired_blt1.GetComponent<Rigidbody2D>().velocity = new Vector2(-firevelocity, 0f);
        fired_blt2 = Instantiate(bullet, firepoint.position+offset2, firepoint.rotation);
        fired_blt2.GetComponent<Rigidbody2D>().velocity = new Vector2(-firevelocity, 0f);
        fired_blt3 = Instantiate(bullet, firepoint.position-offset2, firepoint.rotation);
        fired_blt3.GetComponent<Rigidbody2D>().velocity = new Vector2(-firevelocity, 0f);
        stopfiring();
    }

}
