using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spship_changer : MonoBehaviour
{
    
    string namespaceship=UIvarables.namespaceship;
    public GameObject S_1,S_2,S_3,S_4,S_5,S_6;
    void Start()
    {

    }
    void Update()
    {
        Changespship();
    }
    public void Changespship()
    {
        if(namespaceship=="S_1")
        {
            S_1.SetActive(true);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_1.transform;
            bulletcollision.damage=Spship_details.dmg_S1;
        }
        else if(namespaceship=="S_2")
        {
            S_1.SetActive(false);
            S_2.SetActive(true);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_2.transform;
            bulletcollision.damage=Spship_details.dmg_S2;
        }
        else if(namespaceship=="S_3")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(true);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_3.transform;
            bulletcollision.damage=Spship_details.dmg_S3;
        }
        else if(namespaceship=="S_4")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(true);
            S_5.SetActive(false);
            S_6.SetActive(false);
            followplayer.player=S_4.transform;
            bulletcollision.damage=Spship_details.dmg_S4;
        }
        else if(namespaceship=="S_5")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(true);
            S_6.SetActive(false);
            followplayer.player=S_5.transform;
            bulletcollision.damage=Spship_details.dmg_S5;
        }
        else if(namespaceship=="S_6")
        {
            S_1.SetActive(false);
            S_2.SetActive(false);
            S_3.SetActive(false);
            S_4.SetActive(false);
            S_5.SetActive(false);
            S_6.SetActive(true);
            followplayer.player=S_6.transform;
            bulletcollision.damage=Spship_details.dmg_S6;
        }
    }
    
}
