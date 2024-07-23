using UnityEngine;

public class followplayer : MonoBehaviour
{
    //static int k=0;
    //public Vector3 lshift,Hoffset,Boffset;
    //public Transform Healthbar,Blackbar;
    public Vector3 offset;//is created to destroy plybullet
    Vector3 crtn;
    public static Transform player,t_player;
    public Transform player1;
    void Start()
    {
        crtn.y=player1.position.y+4;
        crtn.z=-10;
        transform.position=crtn;
        //player=player1;
        // if(k==0)
        // {
        //     player=player1;
        //     k++;
        // }
    }
    // Update is called once per frame
    void Update()
    {
        if(player==null)
        {
            Debug.Log("NULL");
            player=player1;
        }
        crtn.x=0;
        crtn.y=player.position.y+4+offset.y;
        transform.position=crtn;
        /*
        Healthbar.position=player.position + Hoffset;
        Blackbar.position=player.position + Boffset+lshift;*/
    }
    void OnTriggerEnter2D(Collider2D collisioninfo)
    {
        if(collisioninfo.tag=="PlyBullet" || collisioninfo.tag=="Bullet")
        {
            Destroy(collisioninfo.gameObject);
        }
    }
    /*
    public void Leftshift()
    {
        Debug.Log("LEFTSHIFT");
        lshift.x-=2.5f;
    }
    */
}
