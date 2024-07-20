using System;
using UnityEditor;
using UnityEngine;

// [System.Serializable]
// public class Spaceshipka
// {
//     public bool unlock;
//     public int damage;
//     public int level;
//     public Spaceshipka(bool unlck,int dmg,int lvl)
//     {
//         unlock=unlck;
//         damage=dmg;
//         level=lvl;
//     }
// }
public class Spship_details : MonoBehaviour
{
    public static bool S1=true,S2=false,S3=true,S4=true,S5=true,S6=true;
    public static int Lvl_S1=1,Lvl_S2=1,Lvl_S3=1,Lvl_S4=1,Lvl_S5=1,Lvl_S6=1;
    public static int dmg_S1=50,dmg_S2=60,dmg_S3=70,dmg_S4=80,dmg_S5=90,dmg_S6=100;
    public static int Hp_S1=200,Hp_S2=250,Hp_S3=300,Hp_S4=350,Hp_S5=400,Hp_S6=450;

    public static int L1_coins=1000,L2_coins=1500,L3_coins=2000,L4_coins=2500,L5_coins=3000;
    // public Spaceshipka Ship1;
    // void Start()
    // {
    //     Ship1.damage=200;
    //     Debug.Log(Ship1.damage);
    // }
}