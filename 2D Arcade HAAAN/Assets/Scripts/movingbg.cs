using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movingbg : MonoBehaviour
{
    public float ypos;
    public Vector3 offset;
    public Transform bg1,bg2,bg3;
    public Rigidbody2D R1,R2,R3;
    void Start()
    {
        R1.velocity=new Vector2(0f,-3f);
        R2.velocity=new Vector2(0f,-3f);
        R3.velocity=new Vector2(0f,-3f);
    }
    void Update()
    {
        if(bg1.position.y<=-ypos)
        {
            bg1.position=offset;
        }
        if(bg2.position.y<=-ypos)
        {
            bg2.position=offset;
        }
        if(bg3.position.y<=-ypos)
        {
            bg3.position=offset;
        }
    }
}
