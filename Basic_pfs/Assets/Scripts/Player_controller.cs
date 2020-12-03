using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_controller : MonoBehaviour
{

    public float player_movement_speed;
    public float player_rotation_speed;


    void Start()
    {

    }

    void Update(){
        float input_horizontal = Input.GetAxis("Horizontal");
        float input_vertical = Input.GetAxis("Vertical");

        transform.Translate(0,0,input_vertical*player_movement_speed);
        transform.Rotate(0,input_horizontal*player_rotation_speed,0);
    }
}
