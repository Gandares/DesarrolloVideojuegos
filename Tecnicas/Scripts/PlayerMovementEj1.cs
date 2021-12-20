using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementEj1 : MonoBehaviour
{
    public delegate void stop();
    public event stop OnStop;
    private float jump = 8f;
    private SpriteRenderer _spriteRenderer;
    private Rigidbody2D _rb;

    void Start()
    {
        _spriteRenderer = gameObject.GetComponent<SpriteRenderer>();
        _rb = gameObject.GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        if(Input.GetButtonDown("Jump") && Mathf.Abs(_rb.velocity.y) < 0.001f){
            _rb.AddForce(new Vector2(0, jump), ForceMode2D.Impulse);
        }
    }

    void OnCollisionEnter2D(Collision2D other) {
        if(other.gameObject.tag == "enemy"){
            OnStop();
            this.gameObject.SetActive(false);
        }
    }
}
