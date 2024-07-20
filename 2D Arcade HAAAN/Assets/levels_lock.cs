using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class levels_lock : MonoBehaviour
{
    public GameObject L02_lock;
    // Start is called before the first frame update
    void Start()
    {
        if (UIvarables.CompLvlno > 0)
        {
            L02_lock.SetActive(false);
            // if (UIvarables.CompLvlno > 1)
            // {
            //     L03_lock.SetActive(false);

            // }
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}
