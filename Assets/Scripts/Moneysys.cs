using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneysys : MonoBehaviour
{
    [SerializeField] int intMoney = 100;
    Text Mohneetext;


    void Start()
    {
        Mohneetext = GetComponent <Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        Mohneetext.text = intMoney.ToString();
    }

    public void AddMoney(int amount)
    {
        intMoney += amount;
        UpdateDisplay();
    }

    public void SpendMoney(int amount)
    {
        if (intMoney >= amount)
        {
            intMoney -= amount;
            UpdateDisplay();
        }
    }




}
