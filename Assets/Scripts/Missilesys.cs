using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Missilesys : MonoBehaviour
{

    [SerializeField] float speed = 1f; //varmisspeed

    void Update()
    {
        transform.Translate(Vector2.right * speed * Time.deltaTime); //varmisspeed
    }
}
