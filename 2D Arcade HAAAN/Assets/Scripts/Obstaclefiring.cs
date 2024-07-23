using System.Collections;
using System.Collections.Generic;
using System.IO.Compression;
using UnityEngine;

public class Obstaclefiring : MonoBehaviour
{
    public float firingspeed=10f;
    Vector3 offset;
    float current_time = 0.5f, starting_time = 1f;
    public GameObject bullet;
    GameObject fired_blt;
    public int blts_no;
    //int i = 0;
    public Transform wrt_camera, enb;
    //public float enbforce;
    //public Rigidbody2D enblt;
    void Start()
    {
        offset.x = 0.4f;
        offset.y = 0;
        offset.z = 0;
        if (blts_no == 1)
        {
            Fire1();
        }
        else if (blts_no == 2)
        {
            Fire2();
        }
    }
    void Update()
    {
        current_time -= 1 * Time.deltaTime;
        if (current_time < 0f)
        {
            current_time = starting_time;
            if (blts_no == 1)
            {
                Fire1();
            }
            else if (blts_no == 2)
            {
                Fire2();
            }
        }
    }
    void Fire1()
    {
        if (transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
        {
            fired_blt = Instantiate(bullet, transform.position, transform.rotation);
            fired_blt.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -firingspeed);
        }

    }
    void Fire2()
    {
        if (transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
        {
            fired_blt = Instantiate(bullet, transform.position + offset, transform.rotation);
            fired_blt.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -firingspeed);
            fired_blt = Instantiate(bullet, transform.position - offset, transform.rotation);
            fired_blt.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, -firingspeed);
        }
    }

    // void Start()
    // {
    //     if (transform.position.y < (wrt_camera.position.y + 9))
    //     {
    //         enb.position=transform.position;
    //         enblt.AddForce(new Vector2(0,-enbforce*Time.deltaTime));
    //         i++;
    //     }

    // }

    void FixedUpdate()
    {
        //-4 since camera position 4 ahead of player
        // if (transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
        // {
        //     Fire();
        // }

        // else if (i == 0 && transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
        // {


        // }
    }
    //transform.position.y>player.position.y && enb.position.y<player.position.y
    // void FixedUpdate()
    // {
    //     //-4 since camera position 4 ahead of player
    //     if (transform.position.y > wrt_camera.position.y - 4 && enb.position.y < (transform.position.y - 9) && transform.position.y < (wrt_camera.position.y + 9 - 4))
    //     {
    //         enblt.AddForce(new Vector2(0, enbforce * Time.deltaTime));
    //         enb.position = transform.position;
    //         enblt.AddForce(new Vector2(0, -enbforce * Time.deltaTime));
    //     }

    //     else if (i == 0 && transform.position.y > wrt_camera.position.y - 4 && transform.position.y < (wrt_camera.position.y + 9 - 4))
    //     {
    //         i++;
    //         enb.position = transform.position;
    //         enblt.AddForce(new Vector2(0, -enbforce * Time.deltaTime));

    //     }
    // }

}
