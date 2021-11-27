using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script1_5 : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) {
        Debug.Log("Detectado trigger.");
    }
}
