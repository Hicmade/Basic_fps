using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biggun_controller : MonoBehaviour
{
    public GameObject crosshairs;
    public int crosshair_type = 1;

    void Start()
    {

    }


    void Update()
    {
        //SHOOT
        if (Input.GetButton("Fire1")){
            GetComponent<Animator>().SetBool("is_shooting", true);
        }   else{
            GetComponent<Animator>().SetBool("is_shooting", false);
        }
    }

    void OnEnable(){
        crosshairs.GetComponent<Crosshair_controler>().ChangeCrosshair(crosshair_type);
    }
}
