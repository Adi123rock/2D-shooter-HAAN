using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using UnityEngine.Video;
using System.Xml.Serialization;
using TMPro;

public class GameMAnager : MonoBehaviour
{
    public Animator headinganimator;

    public TextMeshProUGUI Waveheading;
    bool cont = false;
    int score = 0, waveno = 0;
    public Text scoretext;
    public GameObject After_lose1, After_lose2;
    // public void OpenL02()
    // {
    //     levels_lock.L02_lock.SetActive(false);
    // }
    void Start()
    {
        if (headinganimator != null)
        {
            WaveH_Change();
            Debug.Log("start");
        }

    }
    public void Wave_lvls()
    {
        SceneManager.LoadScene("Wave_lvls");
    }
    public void Lost1()
    {
        Time.timeScale = 0.5f;
        After_lose1.SetActive(true);
        Invoke("Lost2", 5f);
    }
    public void Lost2()
    {
        Debug.Log(!cont);
        if (!cont)
        {
            Time.timeScale = 1f;
            After_lose1.SetActive(false);
            After_lose2.SetActive(true);
            Startgame.EnemiesKilled = 0;
        }
        cont = false;

    }
    public void Continue()
    {
        if (UIvarables.coins >= 3000)
        {
            Debug.Log("ENTERED continue");
            UIvarables.coins -= 3000;
            After_lose1.SetActive(false);
            cont = true;
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
        score += 10;
        scoretext.text = "Score:" + score.ToString();
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
    public void WaveH_Change()
    {
        waveno++;
        Debug.Log(waveno);
        Waveheading.text = "-- Wave " + waveno.ToString() + " --";
        headinganimator.SetBool("Heading", true);
        Invoke("HeadingGo", 2f);
    }
    void HeadingGo()
    {
        headinganimator.SetBool("Heading", false);
    }
}