using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PausePanel : MonoBehaviour
{ 
    public GameObject Paupanel,VolumeOn,VolumeOff; 
    
    public void Pausepan()
    {
        Time.timeScale=0f;
        Paupanel.SetActive(true);
        off();
    }
    public void Resume()
    {
        Time.timeScale=1f;
        Paupanel.SetActive(false);
    }
    public void Volon()
    {
        VolumeOn.SetActive(true);
        VolumeOff.SetActive(false);
    }
    public void Voloff()
    {
        VolumeOff.SetActive(true);
        VolumeOn.SetActive(false);
    }
    public void Home()
    {
        Time.timeScale=1f;
        SceneManager.LoadScene("UI");
    }
    void off()
    {
        Debug.Log("OFF");
        FindObjectOfType<Obstaclefiring>().enabled=false;
    }
}
