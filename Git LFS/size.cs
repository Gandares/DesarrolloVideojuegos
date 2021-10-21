using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Size : MonoBehaviour
{
    public float sizeX;
    public float sizeY;
    public float sizeZ;
    // Start is called before the first frame update
    void Start()
    {
        sizeX = transform.localScale.x;
        sizeY = transform.localScale.y;
        sizeZ = transform.localScale.z;
    }

    // Update is called once per frame
    void Update()
    {
        transform.localScale = new Vector3(sizeX,sizeY,sizeZ);
    }
}
