using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Moneysys : MonoBehaviour
{
    [SerializeField] int intMoney = 100;
    Text Moneytext;


    void Start()
    {
        Moneytext = GetComponent <Text>();
        UpdateDisplay();
    }

    private void UpdateDisplay()
    {
        Moneytext.text = intMoney.ToString();
    }

    public bool HaveMoney(int amount)
    {
        return intMoney >= amount;
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
