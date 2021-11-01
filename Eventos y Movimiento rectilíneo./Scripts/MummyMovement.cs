using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MummyMovement : MonoBehaviour
{
    private Animator anim;
    public GameObject target;
    private Vector3 dir;
    public float speed = 4f;
    
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        dir = target.GetComponent<Transform>().position - this.transform.position;
        
        transform.LookAt(target.GetComponent<Transform>().position);

        if(dir.magnitude > 7f){
            anim.SetBool("move",true);
            transform.position += transform.forward * speed * Time.deltaTime;
        }
        else{
            anim.SetBool("move",false);
        }
    }
}
