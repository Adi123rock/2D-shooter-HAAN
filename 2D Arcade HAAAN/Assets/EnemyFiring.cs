using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class EnemyFiring : MonoBehaviour
{
    void Firebullet(){
    currenttime=starting_time;
    fired_blt=Instantiate(bullet, transform.position, transform.rotation);
    fired_blt.GetComponent<Rigidbody2D>().velocity=new Vector2(0f,-3f);
}
    float currenttime=3f ,  starting_time=3f ;
    public GameObject bullet;
    GameObject fired_blt;
void Update()
{
currenttime=currenttime - Time.deltaTime;
if(currenttime<0f){
    Firebullet();
}
}
}
