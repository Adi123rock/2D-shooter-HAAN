using TMPro;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class bulletcollision : MonoBehaviour
{
    static int a=0;
    public int health=100;

    public Animator headinganimator,villananimator ;
    static int EnemyKilled=0;
    public static int damage=50;
    //public Transform  obst;
    public GameObject explosionEffect,obstacle;
    bool w1don,w2don,w3don,w4don = false;

    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        //Debug.Log("OnCollision");
        //string b=collisionInfo.collider.name;
        if(collisionInfo.tag=="PlyBullet")
        {
            Debug.Log("obstacleCollision");
            health-=damage;
            if(health<=0)
            {
                FindObjectOfType<GameMAnager>().scoreinc();
                explosionEffect.SetActive(true);
                FindObjectOfType<AudioManager>().Play("ObstacleDestroy");
                //Instantiate(explosionEffect,transform.position,transform.rotation);
                Debug.Log("INSTANTIATE");
                Destroy(collisionInfo.gameObject);
                Invoke("Explode",0.5f);
                Debug.Log("INVOKE");
                //Explode();
                //Invoke("Destroyexpl",20f);
            }
        }
        
    }
    void Explode()
    {
        a++;
        // Instantiate(explosionEffect,transform.position,transform.rotation);
        //Debug.Log("off");
        Destroy(obstacle);
        EnemyKilled++;
        //Debug.Log(EnemyKilled);
        // if(animator != null && animator2 != null){
        //     Debug.Log("yep");
        // animator.SetFloat("EnemyKilled",EnemyKilled);
        // animator2.SetFloat("EnemyKilled",EnemyKilled);}
        //explosionEffect.SetActive(false);
    }

    void Update() {
        
        if(headinganimator != null && villananimator != null){
        headinganimator.SetInteger("EnemyKilled",EnemyKilled);
        villananimator.SetInteger("EnemyKilled",EnemyKilled);}


        if((EnemyKilled ==1 && w1don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w1don = true ;
        }
        if((EnemyKilled >2 && w2don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w2don = true ;
        }
        if((EnemyKilled >5 && w3don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w3don = true ;
        }
        if((EnemyKilled >9 && w4don == false)){
            FindObjectOfType<NewBehaviourScript>().fastmoving();
            w4don = true ;
        }
    }
    void Destroyexpl()
    {
        //Destroy(explosionEffect);
    }
}
