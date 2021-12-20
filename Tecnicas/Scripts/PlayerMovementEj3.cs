using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEj3 : MonoBehaviour
{
    public delegate void axisButton(float s1, float s2, float s3);
    public event axisButton OnSetBgSpeed;
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
        if(horizontal < 0){
            _spriteRenderer.flipX = true;
            OnSetBgSpeed(-0.02f,-0.2f,-0.5f);
        } else if(horizontal > 0){
            _spriteRenderer.flipX = false;
            OnSetBgSpeed(0.02f,0.2f,0.5f);
        } else if(horizontal == 0){
            OnSetBgSpeed(0f,0f,0f);
        }
    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rigidbody.velocity.y) < 0.001f){
            _rigidbody.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
            anim.SetTrigger("jump");
        }
    }
}