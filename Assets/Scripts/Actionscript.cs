using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionscript : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject projectile;
    
    public void Fire() 
    {
        Instantiate(projectile, bullet.transform.position, transform.rotation);
    }


}
