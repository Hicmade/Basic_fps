using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crosshair_controler : MonoBehaviour
{
    private int crosshair_amount;

    void Start()
    {
        crosshair_amount = transform.childCount;
    }

    public GameObject ChangeCrosshair(int crosshair_no){

        GameObject crosshair_current = null;

        if (crosshair_no >= crosshair_amount || crosshair_no < 0){
            Debug.Log("There is no such crosshair number");
        } else {
            for (int i =0; i < crosshair_amount; i++){
                transform.GetChild(i).gameObject.SetActive(false);
            }

            crosshair_current = transform.GetChild(crosshair_no).gameObject;
            crosshair_current.SetActive(true);
        }

        return crosshair_current;
    }
}
