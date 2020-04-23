using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionscript : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject projectile;
    AttackerSpawner myLaneSpawner;
    Animator varanimator;

    private void Start()
    {
        SetLaneSpawner();
        varanimator = GetComponent<Animator>();
    }
        
    
    
    private void Update()
    {
        if (IsAttackerInLane())
        {
            varanimator.SetBool("isAttacking", true);
        }
        else
        {
            varanimator.SetBool("isAttacking", false);
        }
    }

    private void SetLaneSpawner()
    {
        AttackerSpawner[] spawners = FindObjectsOfType<AttackerSpawner>();

        foreach (AttackerSpawner spawner in spawners)
        {
            bool IsCloseEnough =
               (Mathf.Abs(spawner.transform.position.y - transform.position.y)
               <= Mathf.Epsilon);
            if (IsCloseEnough)
            {
                myLaneSpawner = spawner;
            }

        }
    }

    private bool IsAttackerInLane()
    {
        if (myLaneSpawner.transform.childCount <= 0)
        {
            return false;
        }
        else
        {
            return true;
        }

        
    }
       


    public void Fire() 
    {
        Instantiate(projectile, bullet.transform.position, transform.rotation);
    }
}
