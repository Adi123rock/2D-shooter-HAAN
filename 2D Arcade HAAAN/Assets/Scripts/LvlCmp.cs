using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Lvlcmp : MonoBehaviour
{
    static int i = 0;
    public static int coins;
    public GameObject Lvlcomp;
    public GameObject winpanel;
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.tag == "Gamecomp")
        {
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
        Lvlcomp.SetActive(false);
        winpanel.SetActive(true);
    }
    //collider.tag=="Gamecomp"
}
