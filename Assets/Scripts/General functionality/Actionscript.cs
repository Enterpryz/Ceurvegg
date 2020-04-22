using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Actionscript : MonoBehaviour
{

    [SerializeField] GameObject bullet;
    [SerializeField] GameObject projectile;
    AttackerSpawner myLaneSpawner;

    private void Start()
    {
        SetLaneSpawner();
    }
        
    
    
    private void Update()
    {
        if (IsAttackerInLane())
        {
            Debug.Log("BANG POW POP WOLLOP");
        }
        else
        {
            Debug.Log("Vibe time");
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
