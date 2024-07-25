using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class bulletcollision : MonoBehaviour
{
    static int EnemyKilled = 0;
    public Animator  villananimator;
    bool dead = true;
    public int health = 100;
    public static int damage = 50;
    //public Transform  obst;
    public GameObject explosionEffect, obstacle;

    void OnTriggerEnter2D(Collider2D collisionInfo)
    {
        //string b=collisionInfo.collider.name;
        if (collisionInfo.tag == "PlyBullet")
        {
            Debug.Log("obstacleCollision");
            health -= damage;
            if (health <= 0 && dead)
            {
                dead = false;
                Startgame.EnemiesKilled++;
                FindObjectOfType<GameMAnager>().scoreinc();
                explosionEffect.SetActive(true);
                FindObjectOfType<AudioManager>().Play("ObstacleDestroy");
                //Instantiate(explosionEffect,transform.position,transform.rotation);
                Debug.Log("INSTANTIATE");
                Destroy(collisionInfo.gameObject);
                Invoke("Explode", 0.5f);
                Debug.Log("INVOKE");
                //Explode();
                //Invoke("Destroyexpl",20f);
            }
        }

    }
    void Update()
    {

        if ( villananimator != null)
        {
            villananimator.SetInteger("EnemyKilled", EnemyKilled);
        }



    }
    void Explode()
    {
        // Instantiate(explosionEffect,transform.position,transform.rotation);
        Debug.Log("off");
        Destroy(obstacle);
        EnemyKilled++;
        if ((EnemyKilled == 1))
        {
            // FindObjectOfType<NewBehaviourScript>().fastmoving();
            FindObjectOfType<GameMAnager>().WaveH_Change();
        }
        else if ((EnemyKilled == 3))
        {
            // FindObjectOfType<NewBehaviourScript>().fastmoving();
            FindObjectOfType<GameMAnager>().WaveH_Change();
        }
        else if ((EnemyKilled == 5))
        {
            // FindObjectOfType<NewBehaviourScript>().fastmoving();
            FindObjectOfType<GameMAnager>().WaveH_Change();
        }
        else if ((EnemyKilled == 8))
        {
            // FindObjectOfType<NewBehaviourScript>().fastmoving();
            FindObjectOfType<GameMAnager>().WaveH_Change();
        }
        else if ((EnemyKilled == 12))
        {
            // FindObjectOfType<NewBehaviourScript>().fastmoving();
            FindObjectOfType<GameMAnager>().WaveH_Change();
        }
        //explosionEffect.SetActive(false);
    }
    void Destroyexpl()
    {
        //Destroy(explosionEffect);
    }
}