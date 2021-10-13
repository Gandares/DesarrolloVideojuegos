using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeColour : MonoBehaviour
{
    private Renderer rend;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collision)
    {
        rend.material.color = Color.red;
    }
}
