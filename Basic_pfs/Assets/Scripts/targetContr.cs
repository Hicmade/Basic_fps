using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class targetContr : MonoBehaviour
{
    [Range(0,2)]
    public int enemy_type;

    public void Hit_target(Vector3 force_dir, float force_strength){
        GetComponent<Rigidbody>().AddForce(force_dir*force_strength);
        StartCoroutine("Destroy_target");
    }

    public void Hit_target(){
        StartCoroutine("Destroy_target");
    }

    IEnumerator Destroy_target(){
        yield return new WaitForSeconds(3);
        Destroy(gameObject);
    }
}
