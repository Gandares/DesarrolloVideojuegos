using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    
    public delegate void Activate();
    public event Activate OnActivate;
    private Rigidbody rb;
    private Animator anim;
    public Transform cam;
    private float turnSmootTime = 0.1f;
    public TP tp0;
    public TP tp1;
    float turnSmootVelocity;
    public float speed = 10f;

    void Start () {
        anim = gameObject.GetComponentInChildren<Animator>();
        rb = GetComponent<Rigidbody>();
        tp0.OnContact += teleport;
        tp1.OnContact += teleport;
    }

    void FixedUpdate()
    {

        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 dir = new Vector3(horizontal, 0f, vertical).normalized;

        if(dir.magnitude >= 0.1f){
            float angle = Mathf.Atan2(dir.x, dir.z) * Mathf.Rad2Deg + cam.eulerAngles.y;
            float smoothAngle = Mathf.SmoothDampAngle(this.transform.eulerAngles.y, angle, ref turnSmootVelocity, turnSmootTime);
            this.transform.rotation = Quaternion.Euler(0f, smoothAngle, 0f);

            Vector3 moveDir = Quaternion.Euler(0f, angle, 0f) * Vector3.forward;
            
            rb.MovePosition(this.transform.position + moveDir.normalized * speed * Time.fixedDeltaTime);
            
            anim.SetInteger ("AnimationPar", 1);
        }
        else{
            anim.SetInteger ("AnimationPar", 0);   
        }     
    }

    void OnTriggerStay(Collider other){
        if(other.gameObject.tag == "Key"){
            if(Input.GetKeyDown(KeyCode.E)){
                Destroy(other.gameObject);
                OnActivate();
            }
        }
    }

    void OnDisable()
    {
        tp0.OnContact -= teleport;
        tp1.OnContact -= teleport;
    }

    void teleport(Vector3 pos){
        this.transform.position = pos;
    }
}
