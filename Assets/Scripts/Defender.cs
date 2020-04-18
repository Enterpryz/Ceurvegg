using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Defender : MonoBehaviour
{

    [SerializeField] int intMoney = 100;



    public int GetDefCost()
    {
        return intMoney;
    }

    public void AddMoney (int amount)
    {
        FindObjectOfType<Moneysys>().AddMoney(amount);
    }

}
