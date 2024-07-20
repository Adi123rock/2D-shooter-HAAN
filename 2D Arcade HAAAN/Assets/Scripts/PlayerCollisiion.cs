using JetBrains.Annotations;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;

public class PlayerCollisiion : MonoBehaviour
{
    public Transform camerapos;
    Vector3 offset;
    public bool once=true;
    public GameObject gameovr;
    //public GAmeOver gAmeOver;
    public forceapply movement;
    float health=100f;
    public float delay=1f;
    public Transform expeffect;
    public GameObject explosionEffect;
    public Text healthtext;
    //public GameMAnager gamem;
    void OnTriggerEnter2D (Collider2D Collisioninfo)
    {
        Debug.Log("ontrigger");
        Debug.Log(Collisioninfo);
        if(Collisioninfo.tag=="Bullet")
        {
            if(health>0){
                health-=50f;
            }
            healthtext.text="HP:"+health.ToString();
            Leshift();
            if(health==0f && once)
            {
                once=false;
                movement.enabled=false;
                expeffect.position=transform.position;
                explosionEffect.SetActive(true);
                FindObjectOfType<AudioManager>().Play("PlayerDeath");
                // Instantiate(explosionEffect,transform.position,transform.rotation);
                Invoke("Gamedone",1f);
                Invoke("GameOver",delay*1f);  
            }
        }
        if(Collisioninfo.tag=="Boss")
        {
            FindObjectOfType<Boss>().enabled=true;
            FindObjectOfType<followplayer>().enabled=false;
            offset=camerapos.position;
            offset.y+=2;
            camerapos.position=offset;
        }
    }
    void GameOver()
    {
        //Destroy(gameObject);
        gameovr.SetActive(false);
        explosionEffect.SetActive(false);
        FindObjectOfType<GameMAnager>().Lost1();
    }
    void Leshift()
    {
        //FindObjectOfType<followplayer>().Leftshift();
        FindObjectOfType<HealthBar>().Dechbar();
    }
    void Gamedone()
    {
        gameovr.SetActive(true);
    }
    public void Continuegame()
    {
        Time.timeScale=1f;
        once=true;
        health=100f;
        healthtext.text="HP:"+health.ToString();
        movement.enabled=true;
        FindObjectOfType<HealthBar>().Fullhp();
    }
    
}
