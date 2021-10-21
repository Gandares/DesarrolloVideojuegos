using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticSphere : MonoBehaviour
{

    private MeshRenderer ren;
    private int contadorMuerte = 5;

    // Start is called before the first frame update
    void Start()
    {
        ren = GetComponent<MeshRenderer>();
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Player"){
            this.transform.localScale = this.transform.localScale - new Vector3(0.1f,0.1f,0.1f);
            ren.material.color = new Color(ren.material.color.r,ren.material.color.g-0.2f,ren.material.color.b);
            contadorMuerte--;
            if(contadorMuerte <= 0)
                Destroy(gameObject);
        }
    }
}
