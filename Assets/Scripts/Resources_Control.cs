using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Resources_Control: MonoBehaviour
{
    public static float money, electricity, minerals;
    public static int currentPopulation, maxPopulation;
    public Text moneyText, electricityText, mineralsText, populationText;

    private void Start()
    {
        money = 100;
    }

    void Update()
    {
        moneyText.text = money.ToString();
        electricityText.text = electricity.ToString();
        mineralsText.text = minerals.ToString();
        populationText.text = currentPopulation.ToString() +"/" + maxPopulation.ToString(); 
    }
}

