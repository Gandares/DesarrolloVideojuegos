using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TP : MonoBehaviour
{
    public delegate void Contact(Vector3 pos);
    public event Contact OnContact;
    private ArrayList TPs = new ArrayList();
    // Start is called before the first frame update
    void Start()
    {
        TPs.Add(GameObject.FindGameObjectsWithTag("TP")[0].GetComponent<Transform>().position);
        TPs.Add(GameObject.FindGameObjectsWithTag("TP")[1].GetComponent<Transform>().position);
    }

    void OnCollisionEnter(Collision col){
        if(col.gameObject.tag == "Player"){
            if(OnContact != null){
                if((GameObject.FindGameObjectsWithTag("TP")[0].GetComponent<Transform>().position - this.transform.position).magnitude < 15f){
                    OnContact(GameObject.FindGameObjectsWithTag("TP")[1].GetComponent<Transform>().position + new Vector3(2f,2f,2f));
                } else{
                    OnContact(GameObject.FindGameObjectsWithTag("TP")[0].GetComponent<Transform>().position + new Vector3(2f,2f,2f));
                }
            }
        }
    }
}
