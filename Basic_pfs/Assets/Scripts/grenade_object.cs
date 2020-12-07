using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade_object : MonoBehaviour
{
    public float throw_force = 200.0f;
    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
    }

    void Update()
    {
        
    }

    public void ReleaseGranade(){
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().AddForce(transform.forward*throw_force);
    }
}
