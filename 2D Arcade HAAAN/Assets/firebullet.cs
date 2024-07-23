using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firebullet : MonoBehaviour
{
    public GameObject bullet;
    GameObject firedblt;
    public Vector3 offset;
    public Transform player,bullt;
    public Rigidbody2D blt;
    // Start is called before the first frame update
    void Start()
    {
       //blt.AddForce(new Vector2(0, firingspeedplayer * Time.deltaTime));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            Debug.Log("FIRE");
            firedblt = Instantiate(bullet, player.position + offset, player.rotation);
            blt = firedblt.GetComponent<Rigidbody2D>();
            Debug.Log(blt);
            firedblt.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 8f);
            // if (blt != null)
            // {
            //     Debug.LogError("Yes Rigidbody component");
            //     firedblt.GetComponent<Rigidbody2D>().velocity = new Vector2(0f, 2f);
            // }
            // else
            // {
            //     Debug.LogError("No Rigidbody component");
            // }
            Debug.Log("passed");
            // Instantiate(bullet, transform.position, transform.rotation);
        }
    }
}
