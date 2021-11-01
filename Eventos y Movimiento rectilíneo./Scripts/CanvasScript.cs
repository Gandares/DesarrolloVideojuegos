using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class CanvasScript : MonoBehaviour
{
    public delegate void buttonAction(bool add);
    public event buttonAction OnButtonAction;
    public Button threeButton;
    public Button sixButton;
    // Start is called before the first frame update
    void Start()
    {
        Button btn3 = threeButton.GetComponent<Button>();
        Button btn6 = sixButton.GetComponent<Button>();
	    btn3.onClick.AddListener(nothing);
        btn6.onClick.AddListener(addThree);
    }

    void nothing(){
        OnButtonAction(false);
        Destroy(this.gameObject);
    }
    void addThree(){
        OnButtonAction(true);
        Destroy(this.gameObject);
    }
}
