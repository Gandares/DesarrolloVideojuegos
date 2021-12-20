using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBackground : MonoBehaviour
{

    private float bgSpeed1 = 0f;
    public Renderer bgRend1;
    private float bgSpeed2 = 0f;
    public Renderer bgRend2;
    private float bgSpeed3 = 0f;
    public Renderer bgRend3;
    public PlayerMovementEj3 pm;

    void Start()
    {
        pm.OnSetBgSpeed += setSpeed;
    }

    void Update()
    {
        bgRend1.material.mainTextureOffset += new Vector2(bgSpeed1 * Time.deltaTime, 0f);
        bgRend2.material.mainTextureOffset += new Vector2(bgSpeed2 * Time.deltaTime, 0f);
        bgRend3.material.mainTextureOffset += new Vector2(bgSpeed3 * Time.deltaTime, 0f);
    }

    void OnDisable()
    {
        pm.OnSetBgSpeed -= setSpeed;
    }

    void setSpeed(float s1, float s2, float s3){
        bgSpeed1 = s1;
        bgSpeed2 = s2;
        bgSpeed3 = s3;
    }


}
