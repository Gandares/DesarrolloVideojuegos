using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Listener : MonoBehaviour{

    public CanvasScript cs;
    public GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cs.OnButtonAction += addThree;
    }

    // Update is called once per frame
    void OnDisable()
    {
        cs.OnButtonAction -= addThree;
    }

    void addThree(bool add){
        Instantiate(cube, new Vector3(30f,30f,30f), Quaternion.identity);
        Instantiate(cube, new Vector3(32f,30f,32f), Quaternion.identity);
        Instantiate(cube, new Vector3(34f,30f,34f), Quaternion.identity);
        if(add){
            Instantiate(cube, new Vector3(32f,30f,30f), Quaternion.identity);
            Instantiate(cube, new Vector3(34f,30f,32f), Quaternion.identity);
            Instantiate(cube, new Vector3(34f,30f,30f), Quaternion.identity);
        }
    }
}
