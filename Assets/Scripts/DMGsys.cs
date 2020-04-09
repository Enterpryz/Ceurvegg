using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMGsys : MonoBehaviour
{
    [SerializeField] float flthealth = 100f;

    public void reducehp(float fltdamage)
    {
        flthealth -= fltdamage;
        if (flthealth <= 0)
        {
            Destroy(gameObject);
        }
    }

}