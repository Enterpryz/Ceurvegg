using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour
{
    [SerializeField] float flthealth = 100f;
    [SerializeField] int intDMGdelay = 4;
    GameObject CurrentTarget;

    [Range (0f, 5f)]
    float fltcurrentSpeed = 1f;

    void Start()
    {
        GetComponent<BoxCollider2D>().enabled = false;
        StartCoroutine(WaitForAttackerSpawn());
    }

    IEnumerator WaitForAttackerSpawn()
    {
        yield return new WaitForSeconds(intDMGdelay);
        GetComponent<BoxCollider2D>().enabled = true;
    }

        void Update()
    {
        transform.Translate(Vector2.left * fltcurrentSpeed * Time.deltaTime);
    }

    public void SetMovementSpeed(float speed)
    {
        fltcurrentSpeed = speed;
    }

    public void Attack(GameObject target)
    {
        GetComponent<Animator>().SetBool("IsAttacking", true);
        CurrentTarget = target;
    }

}
