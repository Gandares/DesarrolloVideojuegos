using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy : MonoBehaviour
{
    private float speed = 7f;
    public PlayerMovementEj1 pm;

    void Start() {
        pm.OnStop += stopIt;    
    }

    void Update()
    {
        transform.position -= new Vector3(1, 0, 0) * Time.deltaTime * speed;
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "delete"){
            this.gameObject.SetActive(false);
        }    
    }

    /*void OnDisable()
    {
        pm.OnStop -= stopIt;
    }*/

    void stopIt(){
        speed = 0f;
    }
}
