using System;
using UnityEditor;
using UnityEngine;

// [System.Serializable]
// public class Spaceshipka
// {
//     public bool unlock;
//     public int damage;
//     public int level;
//     public int upgrade_cost;
//     public Spaceshipka(bool unlck,int dmg,int lvl)
//     {
//         unlock=unlck;
//         damage=dmg;
//         level=lvl;
//     
//     }
// }
public class Spship_details : MonoBehaviour
{
    public static bool S1=true,S2=false,S3=true,S4=true,S5=true,S6=true;

    public static int Lvl_S1=1,Lvl_S2=1,Lvl_S3=1,Lvl_S4=1,Lvl_S5=1,Lvl_S6=1;

    public static int dmg_S1=50,dmg_S2=60,dmg_S3=70,dmg_S4=80,dmg_S5=90,dmg_S6=100;

    public static int Hp_S1=200,Hp_S2=250,Hp_S3=300,Hp_S4=350,Hp_S5=400,Hp_S6=450;

    public static int Upgcost_S1=2500,Upgcost_S2=3000,Upgcost_S3=3500,Upgcost_S4=4000,Upgcost_S5=4500,Upgcost_S6=5000;

    public static int Buycost_S1=2000,Buycost_S2=2500,Buycost_S3=3000,Buycost_S4=3500,Buycost_S5=4000,Buycost_S6=4500;
    
    public static int L1_coins=1000,L2_coins=1500,L3_coins=2000,L4_coins=2500,L5_coins=3000;
    public static int L1_HighScore,L2_HighScore,L3_HighScore,L4_HighScore,L5_HighScore;
    public static int LvlCompno;

    // public Spaceshipka Ship1;
    // void Start()
    // {
    //     Ship1.damage=200;
    //     Debug.Log(Ship1.damage);
    // }
}