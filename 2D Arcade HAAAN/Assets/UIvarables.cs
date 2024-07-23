using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UIvarables : MonoBehaviour
{
    public static int CompLvlno=0;
    //public static Spship_class ship1A,ship2A; 
    public static string namespaceship;
    public static float coins=17000,diamonds=10;
    public TextMeshProUGUI nocoins,nodiamonds;
    // Update is called once per frame
    void Start()
    {
        nocoins.text=coins.ToString();
        nodiamonds.text=diamonds.ToString();
    }
    // public void ship_1commisioned()
    // {
    //     ship1A.unlock=true;
    //     ship1A.damage=30;
    // }
}
