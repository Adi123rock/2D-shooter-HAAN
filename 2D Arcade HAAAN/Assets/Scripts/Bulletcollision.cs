using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bulletcollision : MonoBehaviour
{
    bool dead=true;
    static int a=0;
    public Animator animator,animator2;
    public int health=100;
    public static int damage=50;
    //public Transform  obst;
    public GameObject explosionEffect,obstacle;

    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        //Debug.Log("OnCollision");
        //string b=collisionInfo.collider.name;
        if(collisionInfo.tag=="PlyBullet" )
        {
            Debug.Log("obstacleCollision");
            health-=damage;
            if(health<=0 && dead)
            {
                dead=false;
                Startgame.EnemiesKilled++;
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
        Debug.Log("off");
        Destroy(obstacle);
        if(animator!=null)
        {
            animator.SetInteger("number",a);
            animator2.SetInteger("number",a);
        }
        
        //explosionEffect.SetActive(false);
    }
    void Destroyexpl()
    {
        //Destroy(explosionEffect);
    }
}
