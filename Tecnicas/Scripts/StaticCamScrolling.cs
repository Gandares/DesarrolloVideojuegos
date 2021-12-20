using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StaticCamScrolling : MonoBehaviour
{
    private float bgSpeed = 0.2f;
    public Renderer bgRend;
    public PlayerMovementEj1 pm;

    void Start()
    {
        pm.OnStop += stopIt;
    }

    // Update is called once per frame
    void Update()
    {
        bgRend.material.mainTextureOffset += new Vector2(bgSpeed * Time.deltaTime, 0f);
    }

    void OnDisable()
    {
        pm.OnStop -= stopIt;
    }

    void stopIt(){
        bgSpeed = 0f;
    }
}
