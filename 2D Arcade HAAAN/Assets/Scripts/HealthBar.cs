using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    float health=100f;
    public Slider slider;
    void Start()
    {
        slider.maxValue=health;
        slider.value=health;
    }
    public void Dechbar()
    {
        slider.value-=50f;
    }
    public void Fullhp()
    {
        slider.value=health;
    }
}
