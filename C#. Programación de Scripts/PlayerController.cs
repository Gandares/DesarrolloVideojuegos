using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController character;
    public float speed = 0.1f;
    public float strength = 1000f;
    public int puntuacion = 0;

    void FixedUpdate()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        this.GetComponent<Rigidbody>().MovePosition(this.transform.position + dir * speed * Time.fixedDeltaTime);
    }

    void OnCollisionEnter(Collision collision){
        if(collision.gameObject.tag == "Static"){
            Rigidbody rbother = collision.gameObject.GetComponent<Rigidbody>();
            rbother.AddForce((collision.gameObject.GetComponent<Transform>().position - this.transform.position) * strength);
        }

        if(collision.gameObject.tag != "walltu" && collision.gameObject.tag != "walllr" && collision.gameObject.tag != "floor")
            ScoreScript.scoreValue++;
    }
}
