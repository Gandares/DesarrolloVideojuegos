using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScriptColosiones : MonoBehaviour
{
    // Start is called before the first frame update
    void OnCollisionEnter2D(Collision2D other) {
        Debug.Log("Detectada colisión.");
    }
}
