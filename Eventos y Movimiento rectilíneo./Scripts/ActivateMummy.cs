using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateMummy : MonoBehaviour
{
    public PlayerController pc;
    private Animator anim;
    private bool follow = false; 
    public GameObject target;
    private Vector3 dir;
    public float speed = 4f;
    // Start is called before the first frame update
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        pc.OnActivate += setToActive;
    }

    // Update is called once per frame
    void Update()
    {
        if(follow){
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

    void OnDisable()
    {
        pc.OnActivate -= setToActive;
    }

    void setToActive(){
        follow = true;
    }
}
