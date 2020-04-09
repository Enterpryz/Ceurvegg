using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilesys : MonoBehaviour
{
    [SerializeField] float fltspeed = 1f;
    [SerializeField] float fltdamage = 50f;

    void Update()
    {
        transform.Translate(Vector2.right * fltspeed * Time.deltaTime);
    }

    private void OnTriggerEnter2D(Collider2D externcollision)
    {
        var flthealth = externcollision.GetComponent<DMGsys>();
        flthealth.reducehp(fltdamage);
        Destroy(gameObject);
    }



} // Missilesys

