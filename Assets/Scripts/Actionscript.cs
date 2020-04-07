using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionscript : MonoBehaviour
{

    [SerializeField] GameObject projectile, bullet; //GOprojectiledef
    

    public void Fire() //PubvoidFire(float vardamage)
    {
        Instantiate(projectile, bullet.transform.position, transform.rotation);
    }


}
