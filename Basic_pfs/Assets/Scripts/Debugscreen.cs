using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Debugscreen : MonoBehaviour
{
    public Text myGui;
    public Text myGui2;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetAxis("Mouse Y") != 0){
            //myGui.text = "Mouse X: "+Input.GetAxis("Mouse X")+" Y: "+Input.GetAxis("Mouse Y");
            //myGui2.text = "Camera look angle: "+Camera.main.transform.localEulerAngles;
        }

    }
}
