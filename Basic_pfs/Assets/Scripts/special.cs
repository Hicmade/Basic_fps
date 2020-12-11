using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class special : MonoBehaviour
{
    public GameObject terr;
    public GameObject spec_l;
    public Material mat;

    void OnEnable(){
        terr.GetComponent<MeshRenderer>().material = mat;
        spec_l.SetActive(false);
    }

}
