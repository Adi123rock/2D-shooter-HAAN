using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Instructions : MonoBehaviour
{
    float time = 0f;
    bool fstinst = false;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        time = Time.deltaTime + time ;
        if((time >1.5f) && (fstinst = false)){
            //FindObjectOfType<Canvas>().GetComponent<firebtinst>().SetActive = true ;
        }
    }
}
