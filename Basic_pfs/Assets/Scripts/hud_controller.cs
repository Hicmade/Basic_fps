using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hud_controller : MonoBehaviour
{
    public Text ammo_amount;

    public void UpdateAmmoText(string ammo){
        ammo_amount.text = ammo;
    }
}
