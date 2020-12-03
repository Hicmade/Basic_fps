using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granade_controller : MonoBehaviour
{
     public GameObject crosshairs;
    public int crosshair_type = 2;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnEnable(){
        crosshairs.GetComponent<Crosshair_controler>().ChangeCrosshair(crosshair_type);
    }
}
