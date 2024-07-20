using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    public TextMeshProUGUI lvltext,cointext;
    public GameObject lvlselect;
    static string Lvlno;
    //public GameObject lvl;
    public GameMAnager gamec;
    public void Lvlslct(string name)
    {
        lvlselect.SetActive(true);
        Lvlno=name;
        lvltext.text=Lvlno;
        if(Lvlno=="Level01")
        {
            cointext.text=Spship_details.L1_coins.ToString();
            Lvlcmp.coins=Spship_details.L1_coins;
        }
        else if(Lvlno=="Level02")
        {
            cointext.text=Spship_details.L2_coins.ToString();
            Lvlcmp.coins=Spship_details.L2_coins;
        }
        else if(Lvlno=="Level03")
        {
            cointext.text=Spship_details.L3_coins.ToString();
            Lvlcmp.coins=Spship_details.L3_coins;
        }
        else if(Lvlno=="Level04")
        {
            cointext.text=Spship_details.L4_coins.ToString();
            Lvlcmp.coins=Spship_details.L4_coins;
        }
        else if(Lvlno=="Level05")
        {
            cointext.text=Spship_details.L5_coins.ToString();
            Lvlcmp.coins=Spship_details.L5_coins;
        }
        
        Debug.Log(Lvlno);
        //gamec.GetComponent<GameMAnager>().Lvlselction(Lvlno);
    } 
    public void startgm()
    {
        gamec.GetComponent<GameMAnager>().Lvlselction(Lvlno);
    }
    public void Gamestart()
    {
        Debug.Log(Lvlno);
        //gamec.GetComponent<GameMAnager>().Lvlselction(Lvlno);
    }
    public void lvlsltclose()
    {
        lvlselect.SetActive(false);
    }

    public void Gotolvl()
    {
        FindObjectOfType<AudioManager>().Play("Click");
        gamec.GetComponent<GameMAnager>().Tolvls();
    }
    public void Nextlvl()
    {
        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex+1);
    }
    
}
