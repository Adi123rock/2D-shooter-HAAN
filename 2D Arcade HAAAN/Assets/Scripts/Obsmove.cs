using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obsmove : MonoBehaviour
{
    public float Fmove;
    public Rigidbody2D obs;
    public Transform obstacle;
    // Start is called before the first frame update
    void Start()
    {
        obs.velocity=new Vector2(Fmove,0f);
    }

    // Update is called once per frame
    void Update()
    {
        if(obstacle.position.x>10)
        {
            obs.velocity=new Vector2(-Fmove,0f);
        }
        if(obstacle.position.x<-10)
        {
            obs.velocity=new Vector2(Fmove,0f);
        }
    }
}
