using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilesys : MonoBehaviour
{
    [SerializeField] float fltspeed = 1f;
    [SerializeField] float fltdamage = 20f;

    void Update()
    {
        transform.Translate(Vector2.right * fltspeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D externCollider)
    {
        var health = externCollider.GetComponent<DMGsys>();
        var attacker = externCollider.GetComponent<Attacker>();
        if (attacker && health)
        {
            health.reducehp(fltdamage);
            Destroy(gameObject);
        }
    }
}

