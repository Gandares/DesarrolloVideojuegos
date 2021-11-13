using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SnailAnimation : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private Animator _animator;
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        playerMovement.SetSnailHide += hide;
    }

    void OnDisable()
    {
        playerMovement.SetSnailHide -= hide;
    }

    void hide(bool n){
        _animator.SetBool("near", n);
    }
}
