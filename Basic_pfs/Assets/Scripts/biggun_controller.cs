﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class biggun_controller : MonoBehaviour
{
    public GameObject crosshairs;
    public int crosshair_type = 1;
    public Camera mainCam;
    private GameObject crosshair_current;
    public float shoot_range = 200.0f;
    public float shoot_strength = 300.0f;
    private string ammo_amount = "all";
    public GameObject hud;
    private ParticleSystem shoot_par;
    //public GameObject imp_par;

    void Start()
    {
        shoot_par = gameObject.transform.Find("par_shoot").gameObject.GetComponent<ParticleSystem>();
    }


    void Update()
    {
        //SHOOT
        if (Input.GetButton("Fire1")){
            GetComponent<Animator>().SetBool("is_shooting", true);
            Shoot();
        }   else{
            GetComponent<Animator>().SetBool("is_shooting", false);
        }
    }

    void OnEnable(){
        crosshairs.GetComponent<Crosshair_controler>().ChangeCrosshair(crosshair_type);
        hud.GetComponent<hud_controller>().UpdateAmmoText(ammo_amount);
    }

    private void Shoot(){

        RaycastHit hit;
        if (Physics.Raycast(mainCam.transform.position, mainCam.transform.forward ,out hit, shoot_range)){
            Debug.Log(hit.transform.name);
            targetContr target = hit.transform.GetComponent<targetContr>();
            if (target != null){
                if (target.enemy_type == 1){
                    target.Hit_target(mainCam.transform.forward, shoot_strength);
                }
            }
        }

        shoot_par.Play();
        GetComponent<AudioSource>().Play();

    }
}
