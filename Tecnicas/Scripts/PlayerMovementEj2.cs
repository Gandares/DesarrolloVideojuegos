using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEj2 : MonoBehaviour
{
    private float speed = 5f;
    private float jump = 6f;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rb;
    private Animator anim;
    public Transform bg1;
    public Transform bg2;
    public Transform bc1;
    public Transform bc2;
    private float size;
    void Start()
    {
        anim = gameObject.GetComponentInChildren<Animator>();
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _rb = gameObject.GetComponent<Rigidbody2D>();
        size = bg1.GetComponent<BoxCollider2D>().size.x * 3.23125f;
    }

    void Update()
    {
        transform.position += new Vector3(1, 0, 0) * Time.deltaTime * speed;

        if(transform.position.x >= bg2.position.x){
            bg1.position = new Vector3(bg2.position.x + size, bg2.position.y, 0);
            bc1.position = new Vector3(bc2.position.x + size, bc2.position.y, 0);
            switchBg();
        }
    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001f){
            _rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }

    private void switchBg(){
        Transform temp = bg1;
        bg1 = bg2;
        bg2 = temp;

        temp = bc1;
        bc1 = bc2;
        bc2 = temp;
    }
}

