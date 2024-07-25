using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;

public class Lvlcmp : MonoBehaviour
{ 
    public TextMeshProUGUI timetext;
    static int i = 0;
    public static int coins;
    public GameObject Lvlcomp;
    public GameObject winpanel;
    // Start is called before the first frame update
    float current_time=0;
    void Update()
    {
        current_time+=1*Time.deltaTime;
        //timetext.text=current_time.ToString("0");
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Gamecomp")
        {
            Startgame.total_time=(int)current_time;
            UIvarables.coins+=coins;
            if (i == 0) 
            {
                UIvarables.CompLvlno = 1; 
                i++;
            }
            else
            {
                Debug.Log("ELSE");
                if (SceneManager.GetActiveScene().buildIndex > UIvarables.CompLvlno) 
                {
                    Debug.Log("Buildindex worked");
                    UIvarables.CompLvlno =SceneManager.GetActiveScene().buildIndex;
                }
            }
            //FindObjectOfType<GameMAnager>().OpenL02();
            Lvlcomp.SetActive(true);
            Invoke("Lvlcompl", 1f);

        }
    }
    void Lvlcompl()
    {
        FindObjectOfType<Startgame>().Score();
        Lvlcomp.SetActive(false);
        winpanel.SetActive(true);
    }
    //collider.tag=="Gamecomp"
}
