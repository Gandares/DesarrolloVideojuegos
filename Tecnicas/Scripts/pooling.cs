using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pooling : MonoBehaviour
{
    public GameObject[] enemies;
    private int index = 0;
    public PlayerMovementEj1 pm;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("spawnEnemy",2f,1.5f);
        pm.OnStop += stopIt; 
    }

    private void spawnEnemy(){
        enemies[index].GetComponent<Transform>().position = new Vector3(
            this.transform.position.x,
            Random.Range(this.transform.position.y,
            this.transform.position.y+3f),
            0f
        );
        enemies[index].SetActive(true);
        index++;

        if(index == enemies.Length)
            index = 0;
    }

    void OnDisable()
    {
        pm.OnStop -= stopIt;
    }

    void stopIt(){
        CancelInvoke();
    }
}
