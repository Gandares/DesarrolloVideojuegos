using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{

    private float speed = 5f;
    private float jump = 6f;
    private SpriteRenderer _spriteRenderer;
    private Animator anim;
    private Rigidbody2D _rigidbody;
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _rigidbody = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        anim.SetFloat("speed",Mathf.Abs(horizontal));
        if(horizontal < 0) 
            _spriteRenderer.flipX = true;
        else if(horizontal > 0)
            _spriteRenderer.flipX = false;
        transform.position += new Vector3(horizontal, 0, 0) * Time.deltaTime * speed;

    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f){
            _rigidbody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            anim.SetTrigger("jump");
        }
    }
}
