using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class weapon_controller : MonoBehaviour
{
    public GameObject weapons;
    private int weapons_number;
    private int current_weapon;
    public GameObject player_character;

    void Start()
    {
        //check existance of weapons on the scene
        weapons_number = transform.childCount;

        if (weapons_number != 0){
            current_weapon = 0;
            weapons.transform.GetChild(current_weapon).gameObject.SetActive(true);
        }
        else{
            Debug.Log("No weapons objects on the scene.");
        }
        
    }

    void Update()
    {
        if (Input.GetButtonDown("ChangeWeapon")){
            NextWeapon();
        }
    }

    private void NextWeapon(){
        if (current_weapon >= weapons_number - 1 || current_weapon < 0){
            current_weapon = 0;
        } else {
            current_weapon++;
        }

        //all weapons inactive
        for (int i =0; i < weapons_number; i++){
            weapons.transform.GetChild(i).gameObject.SetActive(false);
        }

        //current weapon active
        weapons.transform.GetChild(current_weapon).gameObject.SetActive(true);
    }
}
