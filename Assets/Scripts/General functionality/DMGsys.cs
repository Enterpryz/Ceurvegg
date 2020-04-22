using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DMGsys : MonoBehaviour
{
    [SerializeField] float flthealth = 100f;
    [SerializeField] GameObject deathVFX;
    
    public void reducehp(float fltdamage)
    {
        flthealth -= fltdamage;
        if (flthealth <= 0)
        {
            TriggerDeathVFX();
            Destroy(gameObject);
        }
    }

    private void TriggerDeathVFX()
    {
        if(!deathVFX) { return; }
        GameObject deathVFXObkect = Instantiate(deathVFX, transform.position, transform.rotation);
    }





}