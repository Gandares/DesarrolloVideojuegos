using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Force : MonoBehaviour
{
    private Rigidbody2D rb;
    public float leftright = 1f;
    public float potencia = 20f;
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>(); 
        rb.AddForce(new Vector3(leftright, 0.0f, 0.0f) * potencia, ForceMode2D.Impulse);
    }
}
