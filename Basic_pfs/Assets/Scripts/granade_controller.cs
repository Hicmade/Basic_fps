using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class granade_controller : MonoBehaviour
{
    public GameObject crosshairs;
    public int crosshair_type = 2;
    public GameObject granade_spawn_point;
    public int granade_number = 3;
    public GameObject granade;
    private GameObject current_granade;

    public GameObject hud;


    void Update(){
        //THROW
        if (Input.GetButtonDown("Fire1") && granade_number > 0){
            GetComponent<Animator>().SetBool("is_shooting", true);
        }   else{
            GetComponent<Animator>().SetBool("is_shooting", false);
        }
    }

    public void OnEnable(){
        crosshairs.GetComponent<Crosshair_controler>().ChangeCrosshair(crosshair_type);
        NextGranade();
        hud.GetComponent<hud_controller>().UpdateAmmoText(granade_number.ToString());
    }

    public void ThrowGranade(){
        current_granade.GetComponent<grenade_object>().ReleaseGranade();
        granade_number--;
        hud.GetComponent<hud_controller>().UpdateAmmoText(granade_number.ToString());
    }

    private void NextGranade(){
        if (granade_number > 0){
            current_granade = Instantiate(granade,granade_spawn_point.transform);

        }
    }
}
