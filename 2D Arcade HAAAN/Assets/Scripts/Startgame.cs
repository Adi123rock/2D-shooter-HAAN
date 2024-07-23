using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Startgame : MonoBehaviour
{
    
    public static int EnemiesKilled=0;
    public static int total_time;
    int score;
    public TextMeshProUGUI scoretext,highscoretext;
    public TextMeshProUGUI lvltext,cointext;
    public GameObject lvlselect;
    static string Lvlno;
    //public GameObject lvl;
    public GameMAnager gamec;
    public void Score()
    {
        score=EnemiesKilled*600/total_time;
        Debug.Log("Score:"+score);
        EnemiesKilled=0;//If we play again its value is coninued from the value of the previous game
        scoretext.text="Score:"+score.ToString("0");
        if(SceneManager.GetActiveScene().buildIndex==1)
        {
            if(Spship_details.L1_HighScore==0)
            {
                highscoretext.text="HighScore:"+score.ToString("0");
                Spship_details.L1_HighScore=score;
                
            }
            else
            {
                if(Spship_details.L1_HighScore < score)
                {
                    highscoretext.text="HighScore:"+score.ToString("0");
                    Spship_details.L1_HighScore = score;
                }
                else
                {
                    highscoretext.text="HighScore:"+Spship_details.L1_HighScore.ToString();
                }
                //Compare score and highscorewww
            }
        }
        else if(SceneManager.GetActiveScene().buildIndex==2)
        {
            if(Spship_details.L2_HighScore==0)
            {
                highscoretext.text="HighScore:"+score.ToString("0");
                Spship_details.L2_HighScore=score;
                
            }
            else
            {
                if(Spship_details.L2_HighScore < score)
                {
                    highscoretext.text="HighScore:"+score.ToString("0");
                    Spship_details.L2_HighScore = score;
                }
                else
                {
                    highscoretext.text="HighScore:"+Spship_details.L2_HighScore.ToString();
                }
                //Compare score and highscorewww
            }
        }
    }
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
