using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lanzadera : MonoBehaviour
{
    public float potencia = 10f;
    void OnTriggerEnter2D(Collider2D other) {
        other.gameObject.GetComponent<Rigidbody2D>().AddForce(transform.right * potencia, ForceMode2D.Impulse);
    }
}
