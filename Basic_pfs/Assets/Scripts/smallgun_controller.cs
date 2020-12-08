using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class smallgun_controller : MonoBehaviour
{
    public GameObject crosshairs;
    public int crosshair_type = 0;
    public Camera mainCam;
    private GameObject crosshair_current;
    public float shoot_range = 200.0f;
    public float shoot_strength = 700.0f;
    private string ammo_amount = "all";
    public GameObject hud;

    void Start()
    {

    }


    void Update()
    {
        //SHOOT
        if (Input.GetButtonDown("Fire1")){
            GetComponent<Animator>().SetBool("is_shooting", true);
            Shoot();
        }   else{
            GetComponent<Animator>().SetBool("is_shooting", false);
        }

        
    }

    private void OnEnable(){
        crosshair_current = crosshairs.GetComponent<Crosshair_controler>().ChangeCrosshair(crosshair_type);
        hud.GetComponent<hud_controller>().UpdateAmmoText(ammo_amount);
    }

    private void Shoot(){

        RaycastHit hit;
        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward ,out hit, shoot_range)){
            Debug.Log(hit.transform.name);
            targetContr target = hit.transform.GetComponent<targetContr>();
            if (target != null){
                if (target.enemy_type == 0){
                    target.Hit_target(mainCam.transform.forward, shoot_strength);
                }
            }
        }
    }
}
