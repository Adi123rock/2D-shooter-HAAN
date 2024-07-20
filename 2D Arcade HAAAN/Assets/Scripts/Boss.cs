using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Boss : MonoBehaviour
{
    public float h_boss = 500f;
    public Slider slider;
    float current_time, starting_time = 10f;
    public Animator animator;
    public GameObject boss_hbar, boss;
    public Transform Bosskahbar, player, firepoint;
    //public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        slider.maxValue = h_boss;
        slider.value = h_boss;
        animator.SetBool("BossEn", true);
        current_time = starting_time;
        //boss_hbar.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        current_time -= 1 * Time.deltaTime;
        //Debug.Log(current_time);
        animator.SetFloat("ply_posx", player.position.x);
        animator.SetFloat("ply_posy", player.position.y);
        if (current_time <= 0f)
        {
            current_time = starting_time;
            Debug.Log("Mlp_fire");
            FindObjectOfType<Mlp_blt_fire>().enabled = true;
            Invoke("stopfiring", 2f);
        }

        //Bosskahbar.position=transform.position;
        //rb.AddForce(new Vector2(0f,10f));
        // if(player.position.y>5)
        // {}
    }
    public void dec_hbar()
    {
        h_boss -= 50f;
        slider.value -= 50f;//player damage minus karenge
        Debug.Log("DEC_");
        if (h_boss <= 250f)
        {
            Debug.Log("BELOW_250HP");
            animator.SetBool("At50hp", true);
            if (h_boss <= 0f)
            {
                animator.SetBool("dead", true);
            }
        }
        Debug.Log("IF_CLEAR");
    }
    void stopfiring()
    {
        current_time = starting_time;
        FindObjectOfType<Mlp_blt_fire>().enabled = false;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Player")
        {
            animator.SetBool("BossEn", true);
            //animator.SetInteger("times",1);
            boss.SetActive(true);
            boss_hbar.SetActive(true);
            Debug.Log("BossEnter");
        }
    }
}
