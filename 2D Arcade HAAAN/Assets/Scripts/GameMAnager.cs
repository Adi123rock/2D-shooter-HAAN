using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System.Xml.Serialization;

public class GameMAnager : MonoBehaviour
{
    bool cont=false;
    int score=0;
    public Text scoretext;
    public GameObject After_lose1,After_lose2;
    // public void OpenL02()
    // {
    //     levels_lock.L02_lock.SetActive(false);
    // }
    
    public void BuyS1A()
    {
        if(UIvarables.CompLvlno>4 && UIvarables.coins>10000)
        {
            Spship_details.S1=true;
            Debug.Log("KHARID LIYA");
            UIvarables.coins-=10000;
            // FindObjectOfType<UIvarables>().ship_1commisioned();
            //ship1A.damage=20;
        }
        else
        {
            if(UIvarables.CompLvlno<5)
            {
                Debug.LogError("FIRST REACH LEVEL 5");
            }
            else
            {
                Debug.LogError("NOT ENOUGH MONEY");
            }
        }
    }
    public void Lost1()
    {
        Time.timeScale=0.5f;
        After_lose1.SetActive(true);
        Invoke("Lost2",5f);
    }
    public void Lost2()
    {
        Debug.Log(!cont);
        if(!cont)
        {
            Time.timeScale=1f;
            After_lose1.SetActive(false);
            After_lose2.SetActive(true);
        }
        cont=false;
        
    }
    public void Continue()
    {
        if(UIvarables.coins>=3000)
        {
            Debug.Log("ENTERED continue");
            UIvarables.coins-=3000;
            After_lose1.SetActive(false);
            cont=true;
            FindObjectOfType<PlayerCollisiion>().Continuegame();
        }
    }
    // public void BacktoHome(string shipname)
    // {
    //     Debug.Log(shipname);
    //     SceneManager.LoadScene("UI");
        
    // }
    public void Spaceships()
    {
        SceneManager.LoadScene("Spaceships");
    }
    public void BacktoHome()
    {
        SceneManager.LoadScene("UI");
    }
    public void scoreinc()
    {
        score+=10;
        scoretext.text="Score:"+score.ToString();
    }
    public void Lvlselction(string level)
    {
        SceneManager.LoadScene(level);
    }
    //GameMAnager gamemanager;
    public void Tolvls()
    {
        SceneManager.LoadScene("Levels");
    }
    public void Endgame()
    {
        restart();
    }
    void restart()
    {
        Debug.Log("GAME OVER");
        SceneManager.LoadScene("UI");
    }
}
