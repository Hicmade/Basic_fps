using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class specbuttion : MonoBehaviour
{
    public GameObject spec;

    void OnTriggerEnter(Collider col){
        if (col.tag == "Player"){
            spec.SetActive(true);
            Destroy(gameObject);
        }
    }
}
