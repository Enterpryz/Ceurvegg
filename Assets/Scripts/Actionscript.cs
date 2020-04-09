using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionscript : MonoBehaviour
{

    [SerializeField] GameObject projectile, bullet; 

    public void Fire() 
    {
        Instantiate(projectile, bullet.transform.position, transform.rotation);
    }


}
