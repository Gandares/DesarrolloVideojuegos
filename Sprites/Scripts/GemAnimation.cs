using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GemAnimation : MonoBehaviour
{
    public PlayerMovement playerMovement;
    private Animator _animator;
    void Start()
    {
        _animator = gameObject.GetComponent<Animator>();
        playerMovement.OnXAction += oneLoop;
    }

    void OnDisable()
    {
        playerMovement.OnXAction -= oneLoop;
    }

    void oneLoop(){
        if(_animator.GetBool("one"))
            _animator.SetBool("one", false);
        else
            _animator.SetBool("one", true);
    }
}
