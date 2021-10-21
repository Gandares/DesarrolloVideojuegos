using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DynamicSphereForce : MonoBehaviour
{
    private Rigidbody rb;
    private MeshRenderer ren;
    private int contadorMuerte = 5;
    private float velocidadConstante = 10f;
    private Vector3 movement;
    public float strength = 200f;
    private Vector3 rotation;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        ren = GetComponent<MeshRenderer>();
        movement = new Vector3(1,0,1) * velocidadConstante * Time.fixedDeltaTime;
    }

    void FixedUpdate()
    {
        rb.MovePosition(this.transform.position + movement);
    }

    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.tag == "Static"){
            Rigidbody rbother = collision.gameObject.GetComponent<Rigidbody>();
            rbother.AddForce((collision.gameObject.GetComponent<Transform>().position - this.transform.position) * strength);
            hallarVectorMovimiento(collision);
        }

        if(collision.gameObject.tag == "Player"){
            hallarVectorMovimiento(collision);
            this.transform.localScale = this.transform.localScale - new Vector3(0.1f,0.1f,0.1f);
            ren.material.color = new Color(ren.material.color.r-0.2f,ren.material.color.g-0.2f,ren.material.color.b);
            contadorMuerte--;
            if(contadorMuerte <= 0)
                Destroy(gameObject);
        }

        if(collision.gameObject.tag == "Dynamic"){
            hallarVectorMovimiento(collision);
        }

        if(collision.gameObject.tag == "walltu"){
            movement[2] = -movement[2];
        }

        if(collision.gameObject.tag == "walllr"){
            movement[0] = -movement[0];
        }
    }

    void hallarVectorMovimiento(Collision collision){
        movement = (this.transform.position - collision.gameObject.GetComponent<Transform>().position) * velocidadConstante * Time.fixedDeltaTime;
        rb.velocity = movement;
    }
}
