using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class grenade_object : MonoBehaviour
{
    public float throw_force = 200.0f;
    public GameObject par_exp;

    private bool is_explosion = false;
    public float radius = 5.0f;
    public float power = 10.0f;
    public float lift = 30.0f;
    public float speed = 10.0f;


    void Start()
    {
        GetComponent<Rigidbody>().useGravity = false;
        GetComponent<Rigidbody>().isKinematic = true;
    }

    void Update()
    {
    
        
    }

    public void ReleaseGranade(){
        transform.parent = null;
        GetComponent<Rigidbody>().useGravity = true;
        GetComponent<Rigidbody>().isKinematic = false;
        GetComponent<Rigidbody>().AddForce(transform.forward*throw_force);
    }

    void OnCollisionEnter(){
        is_explosion = true;
        Debug.Log("explosion bool" + is_explosion);
        GetComponent<AudioSource>().Play();

    }

    void FixedUpdate(){
        if(is_explosion){
            Debug.Log("Is explosion");
            Vector3 explosion_position = transform.position;
            Collider [] colliders = Physics.OverlapSphere(explosion_position, radius);

            foreach(Collider hit in colliders){

                if(hit.GetComponent<Rigidbody>()){
                    hit.GetComponent<Rigidbody>().AddExplosionForce(power, explosion_position, radius, lift);

                    if(hit.transform.tag == "Enemy"){
                        targetContr target = hit.transform.GetComponent<targetContr>();

                        if (target.enemy_type < 2){
                            target.Hit_target(Vector3.zero, 0);
                        }
                    }
                }
            }
            is_explosion = false;
            Debug.Log("is_explosion false");
            EndExplosion();
        }
    }

    void EndExplosion(){
        Debug.Log("end explosion");
        GameObject exp_handler = Instantiate(par_exp, transform.position, Quaternion.identity);
        Destroy(gameObject);
        Destroy(exp_handler, 1.0f);
    }
}
